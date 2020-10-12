using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIt.Logica;
using System.Data;

namespace TestIt.Datos
{
    class TestDao
    {
        public List<Test> buscarTests()
        {
            String consultaSql = string.Concat("SELECT * FROM Tests WHERE borrado=0");

            var resultado = DataManager.GetInstance().ConsultaSQL(consultaSql);

            if (resultado.Rows.Count > 0)
            {
                List<Test> tests = new List<Test>();
                foreach (DataRow row in resultado.Rows)
                    tests.Add(mappingTest(row));
                return tests;
            }

            return null;
        }

        public List<Test> filtrarTests(string nombre)
        {
            String consultaSql = string.Concat("SELECT * FROM Tests WHERE borrado=0");

            if (nombre != "") consultaSql += " AND nombre LIKE '" + nombre + "%'";

            var resultado = DataManager.GetInstance().ConsultaSQL(consultaSql);

            if (resultado.Rows.Count > 0)
            {
                List<Test> tests = new List<Test>();
                foreach (DataRow row in resultado.Rows)
                    tests.Add(mappingTest(row));
                return tests;
            }

            return null;
        }

        private List<int> buscarIdMediciones(int testId)
        {
            String consultaSql = string.Concat("SELECT id_campo FROM medicionesxTests WHERE id_test = " + testId);

            var resultado = DataManager.GetInstance().ConsultaSQL(consultaSql);

            List<int> idMediciones = new List<int>();

            if (resultado.Rows.Count > 0)
            {
                foreach (DataRow row in resultado.Rows)
                {
                    idMediciones.Add((int)row["id_campo"]);
                }            
            }
            return idMediciones;
        }

        private Test mappingTest(DataRow row)
        {
            Test oTest = new Test(Convert.ToInt32(row["id"]));

            oTest.Nombre = row["nombre"].ToString();
            oTest.Descripcion = row["descripcion"].ToString();
            oTest.Borrado = Convert.ToInt32(row["borrado"]);
            oTest.IdMediciones = buscarIdMediciones((int)row["id"]);

            return oTest;
        }

        public bool Create(Test oTest)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                //SIN PARAMETROS

                string str_sql = "INSERT INTO Tests VALUES ('" +
                            oTest.Nombre + "', '" +
                            oTest.Descripcion + "', 0)";

                dm.EjecutarSQL(str_sql);
                int newId = Convert.ToInt32(dm.ConsultaSQLScalar(" SELECT @@IDENTITY"));

                foreach (int idMedicion in oTest.IdNuevas)
                {
                    str_sql = "INSERT INTO MedicionesXTests VALUES (" + idMedicion + "," + newId + ",0)";
                    dm.EjecutarSQL(str_sql);
                }

                dm.Commit();
            }

            catch (Exception ex)
            {
                dm.Rollback();
                throw ex;
            }
            finally
            {
                dm.Close();
            }
            return true;
        }

        internal bool Update(Test oTest)
        {

            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                string str_sql = "UPDATE Tests SET " +
                              "nombre='" + oTest.Nombre + "' ," +
                              "descripcion= " + "'" + oTest.Descripcion +
                              "' WHERE id=" + oTest.Id + " AND  borrado=0";

                dm.EjecutarSQL(str_sql);
                
                foreach (int idMedicion in oTest.IdNuevas)
                {
                    str_sql = "INSERT INTO MedicionesXTests VALUES (" + idMedicion + "," + oTest.Id + ",0)";
                    dm.EjecutarSQL(str_sql);
                }

                foreach (int idMedicion in oTest.IdEliminadas)
                {
                    str_sql = "DELETE FROM MedicionesXTests WHERE id_campo =" + idMedicion + " AND id_test = " + oTest.Id;
                    dm.EjecutarSQL(str_sql);
                }

                dm.Commit();
            }
            catch (Exception ex)
            {
                dm.Rollback();
                throw ex;
            }
            finally
            {
                dm.Close();
            }
            return true;
        }

        public bool Delete(Test oTest)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                string str_sql = "UPDATE Tests" +
                                " SET borrado = " + 1 +
                                " WHERE id = " + oTest.Id;

                dm.EjecutarSQL(str_sql);

                foreach (int idMedicion in oTest.IdMediciones)
                {
                    str_sql = "UPDATE MedicionesXTests SET borrado = 1 WHERE id_campo =" + idMedicion + " AND id_test = " + oTest.Id;
                    dm.EjecutarSQL(str_sql);
                }

                dm.Commit();
            }

            catch (Exception ex)
            {
                dm.Rollback();
                throw ex;
            }

            finally
            {
                dm.Close();
            }

            return true;
        }
    }
}
