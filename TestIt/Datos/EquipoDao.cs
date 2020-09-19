using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIt.Logica;
using System.Data;

namespace TestIt.Datos
{
    class EquipoDao
    {
        public List<Equipo> buscarEquipos()
        {
            String consultaSql = string.Concat("SELECT * FROM Equipos WHERE borrado=0");

            var resultado = DataManager.GetInstance().ConsultaSQL(consultaSql);

            if (resultado.Rows.Count > 0)
            {
                List<Equipo> equipos = new List<Equipo>();
                foreach (DataRow row in resultado.Rows)
                    equipos.Add(mappingEquipo(row));
                return equipos;
            }

            return null;
        }

        public List<Equipo> filtrarEquipos(string nombre, string localidad)
        {
            String consultaSql = string.Concat("SELECT * FROM Equipos WHERE borrado=0");

            if (nombre != "") consultaSql += " AND nombre LIKE '" + nombre + "%'";
            if (localidad != "") consultaSql += " AND localidad LIKE '" + localidad + "%'";

            var resultado = DataManager.GetInstance().ConsultaSQL(consultaSql);

            if (resultado.Rows.Count > 0)
            {
                List<Equipo> equipos = new List<Equipo>();
                foreach (DataRow row in resultado.Rows)
                    equipos.Add(mappingEquipo(row));
                return equipos;
            }

            return null;
        }

        private Equipo mappingEquipo(DataRow row)
        {
            Equipo oEquipo = new Equipo(Convert.ToInt32(row["id"]));

            oEquipo.Nombre = row["nombre"].ToString();
            oEquipo.Localidad = row["localidad"].ToString();
            oEquipo.Entrenador = row["entrenador"].ToString();
            oEquipo.Borrado = Convert.ToInt32(row["borrado"]);

            return oEquipo;
        }

        public bool Create(Equipo oEquipo)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                //SIN PARAMETROS

                string str_sql = "INSERT INTO Equipos VALUES ('" +
                            oEquipo.Nombre + "', '" +
                            oEquipo.Localidad + "' , '" +
                            oEquipo.Entrenador + "', 0)";

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

        internal bool Update(Equipo oEquipo)
        {

            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                string str_sql = "UPDATE Equipos SET " +
                              "nombre='" + oEquipo.Nombre + "'," +
                              "localidad= " + "'" + oEquipo.Localidad + "'," +
                              "entrenador= '" + oEquipo.Entrenador +
                              "' WHERE id=" + oEquipo.Id + " AND  borrado=0";

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

        public bool Delete(Equipo oEquipo)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                string str_sql = "UPDATE Equipos " +
                             "SET borrado = " + 1 +
                " WHERE id = " + oEquipo.Id;

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
