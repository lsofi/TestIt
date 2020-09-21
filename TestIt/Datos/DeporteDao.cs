 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIt.Logica;
using System.Data;



namespace TestIt.Datos
{
    class DeporteDao
    {
        public List<Deporte> buscarDeporte()
        {
            String consultaSql = string.Concat("SELECT * FROM Deportes WHERE borrado=0");

            var resultado = DataManager.GetInstance().ConsultaSQL(consultaSql);

            if (resultado.Rows.Count > 0)
            {
                List<Deporte> deportes = new List<Deporte>();
                foreach (DataRow row in resultado.Rows)
                    deportes.Add(mappingDeporte(row));
                return deportes;
            }

            return null;
        }

        private Deporte mappingDeporte(DataRow row)
        {
           Deporte oDeporte = new Deporte(Convert.ToInt32(row["id"]));

            oDeporte.Nombre = row["nombre"].ToString();
            oDeporte.Borrado = Convert.ToInt32(row["borrado"]);
            return oDeporte;
        }

        public bool Create(Deporte oDeporte)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                //SIN PARAMETROS

                string str_sql = "INSERT INTO Deportes VALUES ('" +
                            oDeporte.Nombre + "')";
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

        internal bool Update(Deporte oDeporte)
        {

            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                string str_sql = "UPDATE Deportes SET " +
                              "nombre='" + oDeporte.Nombre + "'," + 
                              "WHERE id= " + oDeporte.Id + " AND  borrado=0";

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

        public bool Delete(Deporte oDeporte)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                string str_sql = "UPDATE Deportes " +
                             "SET borrado = " + 1 +
                            " WHERE id = " + oDeporte.Id;

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

