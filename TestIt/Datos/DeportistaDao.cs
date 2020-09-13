using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIt.Logica;
using System.Data;

namespace TestIt.Datos
{
    class DeportistaDao
    {
        public List<Deportista> buscarDeportistas()
        {
            String consultaSql = string.Concat("SELECT * FROM Deportistas WHERE borrado=0");

            var resultado = DataManager.GetInstance().ConsultaSQL(consultaSql);

            if (resultado.Rows.Count > 0)
            {
                List<Deportista> deportistas = new List<Deportista>();
                foreach(DataRow row in resultado.Rows)
                    deportistas.Add(mappingDeportista(row));
                return deportistas;
            }

            return null;
        }

        public List<Deportista> filtrarDeportistas(string apellido, int equipo, int deporte, int categoria)
        {
            String consultaSql = string.Concat("SELECT * FROM Deportistas WHERE borrado=0");

            if (apellido != "") consultaSql += " AND apellido LIKE '" + apellido + "%'";
            if (equipo != -1) consultaSql += " AND id_equipo = " + equipo;
            if (deporte != -1) consultaSql += " AND id_deporte = " + deporte;
            if (categoria != -1) consultaSql += " AND id_categoria = " + categoria;

            var resultado = DataManager.GetInstance().ConsultaSQL(consultaSql);

            if (resultado.Rows.Count > 0)
            {
                List<Deportista> deportistas = new List<Deportista>();
                foreach (DataRow row in resultado.Rows)
                    deportistas.Add(mappingDeportista(row));
                return deportistas;
            }

            return null;
        }

        private Deportista mappingDeportista(DataRow row)
        {
            Deportista oDeportista = new Deportista(Convert.ToInt32(row["id"]));

            oDeportista.Dni = Convert.ToInt32(row["dni"]);
            oDeportista.Apellido = row["apellido"].ToString();
            oDeportista.Nombre = row["nombre"].ToString();
            oDeportista.Altura = Convert.ToDouble(row["altura"]);
            oDeportista.Peso = Convert.ToDouble(row["peso"]);
            oDeportista.Sexo = Convert.ToInt32(row["sexo"]);
            oDeportista.Nacimiento = DateTime.Parse(row["fecha_nacimiento"].ToString());
            oDeportista.IdEquipo = Convert.ToInt32(row["id_equipo"]);
            oDeportista.IdDeporte = Convert.ToInt32(row["id_deporte"]);
            oDeportista.IdCategoria = Convert.ToInt32(row["id_categoria"]);
            oDeportista.Borrado = Convert.ToInt32(row["borrado"]);

            return oDeportista;
        }

        public bool Create(Deportista oDeportista)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                //SIN PARAMETROS

                string str_sql = "INSERT INTO Deportistas (dni, apellido, nombre, altura, peso, sexo, fecha_nacimiento, id_equipo, id_deporte, id_categoria, borrado)" +
                            " VALUES (" +
                            oDeportista.Dni + ", '" +
                            oDeportista.Apellido + "' , '" +
                            oDeportista.Nombre + "' ," +
                            oDeportista.Altura + ", " +
                            oDeportista.Peso + ", " +
                            oDeportista.Sexo + ", '" +
                            oDeportista.Nacimiento.ToString("yyyy-MM-dd") + "', " +
                            oDeportista.IdEquipo + ", " +
                            oDeportista.IdDeporte + ", " +
                            oDeportista.IdCategoria + ", 0)";

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

        internal bool Update(Deportista oDeportista)
        {

            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                string str_sql = "UPDATE Deportistas " +
                             "SET dni=" + oDeportista.Dni + "," +
                              "apellido= " + "'" + oDeportista.Apellido + "'" + "," +
                              "nombre= " + "'" + oDeportista.Nombre + "' ," +
                              "altura= " + oDeportista.Altura + ", " +
                              "peso= " + oDeportista.Peso + ", " +
                              "sexo= " + oDeportista.Sexo + ", " +
                              "fecha_nacimiento= '" + oDeportista.Nacimiento.ToString("yyyy-MM-dd") + "', " +
                              "id_equipo= " + oDeportista.IdEquipo + ", " +
                              "id_deporte= " + oDeportista.IdDeporte + ", " +
                              "id_categoria=" + oDeportista.IdCategoria +
                              " WHERE id=" + oDeportista.Id + " AND  borrado=0";

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

        public bool Delete(Deportista oDeportista)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                string str_sql = "UPDATE Deportistas " +
                             "SET borrado = " + 1 +
                " WHERE id = " + oDeportista.Id;

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
