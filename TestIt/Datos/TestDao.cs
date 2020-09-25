using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIt.Logica;

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
                List<Medicion> mediciones = new List<Medicion>();
                foreach (DataRow row in resultado.Rows)
                    mediciones.Add(mappingMedicion(row));
                return mediciones;
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
                List<Medicion> mediciones = new List<Medicion>();
                foreach (DataRow row in resultado.Rows)
                    mediciones.Add(mappingMedicion(row));
                return mediciones;
            }

            return null;
        }

        private Medicion mappingMedicion(DataRow row)
        {
            Medicion oMedicion = new Medicion(Convert.ToInt32(row["id"]));

            oMedicion.Nombre = row["nombre"].ToString();
            oMedicion.Unidad = row["unidad"].ToString();
            oMedicion.Descripcion = row["descripcion"].ToString();
            oMedicion.Borrado = Convert.ToInt32(row["borrado"]);

            return oMedicion;
        }

        public bool Create(Medicion oMedicion)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                //SIN PARAMETROS

                string str_sql = "INSERT INTO Mediciones VALUES ('" +
                            oMedicion.Nombre + "', '" +
                            oMedicion.Unidad + "', '" +
                            oMedicion.Descripcion + "', 0)";

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

        internal bool Update(Medicion oMedicion)
        {

            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                string str_sql = "UPDATE Mediciones SET " +
                              "nombre='" + oMedicion.Nombre + "' ," +
                              "unidad= " + "'" + oMedicion.Unidad + "' ," +
                              "descripcion= " + "'" + oMedicion.Descripcion +
                              "' WHERE id=" + oMedicion.Id + " AND  borrado=0";

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

        public bool Delete(Medicion oMedicion)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                string str_sql = "UPDATE Mediciones" +
                                " SET borrado = " + 1 +
                                " WHERE id = " + oMedicion.Id;

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
