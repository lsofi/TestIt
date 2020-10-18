using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TestIt.Logica;

namespace TestIt.Datos
{
    class MedicionDao
    {

        public List<Medicion> buscarMediciones()
        {
            String consultaSql = string.Concat("SELECT * FROM Mediciones WHERE borrado=0");

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

        public Medicion buscarMedicionPorId(int id)
        {
            var resultado = DataManager.GetInstance().ConsultaSQL("SELECT * FROM mediciones WHERE id = " + id);
            if (resultado.Rows.Count > 0)
                return mappingMedicion(resultado.Rows[0]);
            return null;
        }

        public DataTable buscarMedicionesPorTest(int idTest)
        {
            var resultado = DataManager.GetInstance().ConsultaSQL(
                "SELECT m.id, m.nombre FROM mediciones m" +
                " JOIN medicionesXtests t ON m.id = t.id_campo " +
                " WHERE t.id_test = " + idTest);

            return resultado;
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

        public int getId(string nombre)
        {
            var respuesta = DataManager.GetInstance().ConsultaSQLScalar("SELECT id FROM mediciones WHERE nombre = '" + nombre + "'");
            if (respuesta == null) return -1;
            return (int)respuesta;
        }

        public string getNombre(int id)
        {
            return DataManager.GetInstance().ConsultaSQLScalar("SELECT nombre FROM mediciones WHERE id = " + id).ToString();
        }

        public string getUnidad(int id)
        {
            return DataManager.GetInstance().ConsultaSQLScalar("SELECT unidad FROM mediciones WHERE id = " + id).ToString();
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
