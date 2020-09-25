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
        public List<Test> buscarTest()
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

        public List<Medicion> filtrarMediciones(string nombre)
        {
            String consultaSql = string.Concat("SELECT * FROM Mediciones WHERE borrado=0");

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

        private Medicion mappingTest(DataRow row)
        {
            Test oTest = new Test(Convert.ToInt32(row["id"]));

            oTest.Nombre = row["nombre"].ToString();
            oTest.Descripcion = row["descripcion"].ToString();
            oTest.Borrado = Convert.ToInt32(row["borrado"]);

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
