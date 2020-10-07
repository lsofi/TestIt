using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIt.Logica;

namespace TestIt.Datos
{
    class EjecucionDao
    {
        public List<Ejecucion> buscarEjecuciones()
        {
            String consultaSql = string.Concat("SELECT * FROM Ejecuciones WHERE borrado=0");

            var resultado = DataManager.GetInstance().ConsultaSQL(consultaSql);

            if (resultado.Rows.Count > 0)
            {
                List<Ejecucion> ejecuciones = new List<Ejecucion>();
                foreach (DataRow row in resultado.Rows)
                {
                    DataTable mediciones = buscarMediciones((int)row["nro_ejecucion"]);

                    ejecuciones.Add(mappingEjecucion(row, mediciones));
                }
                return ejecuciones;
            }

            return null;
        }

        public List<Ejecucion> filtrarEjecuciones(int test, int deportista, DateTime fechaDesde, DateTime fechaHasta)
        {
            String consultaSql = string.Concat("SELECT * FROM Ejecuciones WHERE borrado=0");

            if (test != -1) consultaSql += " AND id_test = " + test;
            if (deportista != -1) consultaSql += " AND id_deportista = " + deportista;
            consultaSql += " AND fecha BETWEEN '" + fechaDesde.ToString("yyyy-MM-dd") + "' AND '" + fechaHasta.ToString("yyyy-MM-dd") + "'";

            var resultado = DataManager.GetInstance().ConsultaSQL(consultaSql);

            if (resultado.Rows.Count > 0)
            {
                List<Ejecucion> ejecuciones = new List<Ejecucion>();
                foreach (DataRow row in resultado.Rows)
                {
                    DataTable mediciones = buscarMediciones((int)row["nro_ejecucion"]);
                    ejecuciones.Add(mappingEjecucion(row, mediciones));
                }
                return ejecuciones;
            }

            return null;
        }

        private DataTable buscarMediciones(int nro_ejecucion)
        {
            String consultaSql = "SELECT * FROM detalle_ejecuciones WHERE borrado = 0 AND nro_ejecucion = " + nro_ejecucion;
            return DataManager.GetInstance().ConsultaSQL(consultaSql);
        }

        private Ejecucion mappingEjecucion(DataRow row, DataTable mediciones)
        {
            Ejecucion oEjecucion = new Ejecucion(Convert.ToInt32(row["nro_ejecucion"]));

            oEjecucion.IdTest = Convert.ToInt32(row["id_test"]);
            oEjecucion.IdDeportista = Convert.ToInt32(row["id_deportista"]);
            oEjecucion.Fecha = DateTime.Parse(row["fecha"].ToString());
            oEjecucion.Borrado = Convert.ToInt32(row["borrado"]);

            foreach (DataRow mRow in mediciones.Rows)
            {
                oEjecucion.addMedicion((int)mRow["id_campo"], mRow["valor"].ToString());
            }

            return oEjecucion;
        }

        public bool Create(Ejecucion oEjecucion)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                //SIN PARAMETROS

                string str_sql = "INSERT INTO Ejecuciones VALUES (" +
                            oEjecucion.IdTest + ", " +
                            oEjecucion.IdDeportista + ", " +
                            oEjecucion.IdUsuario + ", '" +
                            oEjecucion.Fecha.ToString("yyyy-MM-dd") + "', ";
                if (oEjecucion.Observacion == null) str_sql += "NULL";
                else str_sql += "'" + oEjecucion.Observacion + "'";
                str_sql += ", 0)";

                dm.EjecutarSQL(str_sql);
                int newId = Convert.ToInt32(dm.ConsultaSQLScalar(" SELECT @@IDENTITY"));

                foreach (int key in oEjecucion.Mediciones.Keys)
                {
                    string valor = oEjecucion.Mediciones[key];
                    str_sql = "INSERT INTO Detalle_Ejecuciones VALUES (" + newId + "," + key + ", ";
                    if (valor == null) str_sql += "NULL";
                    else str_sql += "'" + valor + "'";
                    str_sql += ", 0)";

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

        public bool Update(Ejecucion oEjecucion)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();

                foreach (int key in oEjecucion.Mediciones.Keys)
                {
                    string valor = oEjecucion.Mediciones[key];
                    string str_sql = "UPDATE Detalle_Ejecuciones SET valor = " + oEjecucion.Mediciones[key] + 
                        " WHERE nro_ejecucion = " + oEjecucion.Numero + " AND id_campo = " + key;
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

        public bool Delete(Ejecucion oEjecucion)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                string str_sql = "UPDATE Ejecuciones" +
                                " SET borrado = " + 1 +
                                " WHERE nro_ejecucion = " + oEjecucion.Numero;

                dm.EjecutarSQL(str_sql);

                foreach (int key in oEjecucion.Mediciones.Keys)
                {
                    str_sql = "UPDATE Detalle_Ejecuciones SET borrado = 1 WHERE id_campo =" + key + " AND nro_ejecucion = " + oEjecucion.Numero;
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
