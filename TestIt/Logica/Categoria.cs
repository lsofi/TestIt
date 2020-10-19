using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIt.Datos;

namespace TestIt.Logica
{
    class Categoria
    {

        private static CategoriaDao cDao = new CategoriaDao();

        private int id;
        private string nombre;
        private int edadMin;
        private int edadMax;
        private int borrado;

        public Categoria(int id)
        {
            this.id = id;
        }
        public Categoria()
        {
        }

        public int Id { get => id; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int EdadMin { get => edadMin; set => edadMin = value; }
        public int EdadMax { get => edadMax; set => edadMax = value; }
        public int Borrado { get => borrado; set => borrado = value; }

        public static List<Categoria> buscarCategorias()
        {
            return cDao.buscarCategoria();
        }

        public static string buscarNombre(int id)
        {
            return cDao.buscarNombre(id);
        }

        public bool grabar()
        {
            return cDao.Create(this);
        }

        public bool actualizar()
        {
            return cDao.Update(this);
        }

        public bool eliminar()
        {
            return cDao.Delete(this);
        }
    }
}
