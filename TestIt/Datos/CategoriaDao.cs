using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIt.Logica;
using System.Data;

namespace TestIt.Datos
{
    class CategoriaDao : AbstractDao
    {
        public CategoriaDao() : base("categorias") { }

        protected override object mappingObject(DataRow row)
        {
            Categoria oCategoria = new Categoria(Convert.ToInt32(row["id"]));

            oCategoria.Nombre = row["nombre"].ToString();
            oCategoria.EdadMin = Convert.ToInt32(row["edad_min"]);
            oCategoria.EdadMax = Convert.ToInt32(row["edad_max"]);
            oCategoria.Borrado = Convert.ToInt32(row["borrado"]);
            return oCategoria;
        }

        protected override void sqlCreate(object o)
        {
            Categoria oCategoria = (Categoria)o;

            string str_sql = "INSERT INTO Categorias VALUES ('" +
                              oCategoria.Nombre + "', " +
                              oCategoria.EdadMin + " , " +
                              oCategoria.EdadMax + ", 0)";

            DataManager.GetInstance().EjecutarSQL(str_sql);
        }

        protected override void sqlUpdate(object o)
        {
            Categoria oCategoria = (Categoria)o;

            string str_sql = "UPDATE Categorias SET " +
                             "nombre='" + oCategoria.Nombre + "'," +
                             "edad_min= " + oCategoria.EdadMin + ", " +
                             "edad_max= " + oCategoria.EdadMax +
                             "WHERE id= " + oCategoria.Id + " AND  borrado=0";

            DataManager.GetInstance().EjecutarSQL(str_sql);
        }

        protected override void sqlDelete(object o)
        {
            Categoria oCategoria = (Categoria)o;

            string str_sql = "UPDATE Categorias " +
                             "SET borrado = " + 1 +
                             " WHERE id = " + oCategoria.Id;

            DataManager.GetInstance().EjecutarSQL(str_sql);
        }
    }
}

