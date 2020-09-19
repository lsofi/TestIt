using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIt.Logica;
using System.Data;



namespace TestIt.Datos
{
    class CategoriaDao
    {
        public List<Categoria> buscarCategoria()
        {
            String consultaSql = string.Concat("SELECT * FROM Categorias WHERE borrado=0");

            var resultado = DataManager.GetInstance().ConsultaSQL(consultaSql);

            if (resultado.Rows.Count > 0)
            {
                List<Categoria> categorias = new List<Categoria>();
                foreach (DataRow row in resultado.Rows)
                    categorias.Add(mappingCategoria(row));
                return categorias;
            }

            return null;
        }

        private Categoria mappingCategoria(DataRow row)
        {
           Categoria oCategoria = new Categoria(Convert.ToInt32(row["id"]));

            oCategoria.Nombre = row["nombre"].ToString();
            oCategoria.EdadMin = Convert.ToInt32(row["edad_min"]);
            oCategoria.EdadMax = Convert.ToInt32(row["edad_max"]);
            oCategoria.Borrado = Convert.ToInt32(row["borrado"]);
            return oCategoria;
        }

        public bool Create(Categoria oCategoria)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                //SIN PARAMETROS

                string str_sql = "INSERT INTO Categorias VALUES ('" +
                            oCategoria.Nombre + "', " +
                            oCategoria.EdadMin + " , " +
                            oCategoria.EdadMax + ", 0)";

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

        internal bool Update(Categoria oCategoria)
        {

            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                string str_sql = "UPDATE Categorias SET " +
                              "nombre='" + oCategoria.Nombre + "'," +
                              "edad_min= " + oCategoria.EdadMin + ", " +
                              "edad_max= " + oCategoria.EdadMax + 
                              "WHERE id= " + oCategoria.Id + " AND  borrado=0";

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

        public bool Delete(Categoria oCategoria)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                string str_sql = "UPDATE Categorias " +
                             "SET borrado = " + 1 +
                            " WHERE id = " + oCategoria.Id;

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

