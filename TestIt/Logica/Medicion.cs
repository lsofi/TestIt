using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIt.Datos;

namespace TestIt.Logica
{
    class Medicion
    {

        private static MedicionDao mDao = new MedicionDao();

        private int id;
        private string nombre;
        private string unidad;
        private string descripcion;
        private int borrado;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Borrado { get => borrado; set => borrado = value; }
        public string Unidad { get => unidad; set => unidad = value; }

        public Medicion(int id)
        {
            this.id = id;
        }

        public Medicion()
        {
        }

        public static List<Medicion> buscarMediciones()
        {
            return mDao.buscarMediciones();
        }

        public static List<Medicion> filtrarMediciones(string nombre)
        {
            return mDao.filtrarMediciones(nombre);
        }

        public static int buscarId(string nombre)
        {
            return mDao.getId(nombre);
        }

        public static string buscarNombre(int id)
        {
            return mDao.getNombre(id);
        }
        public static string buscarUnidad(int id)
        {
            return mDao.getUnidad(id);
        }


        public static Medicion buscarMedicionPorId(int id)
        {
            return mDao.buscarMedicionPorId(id);
        }

        public bool grabar()
        {
            return mDao.Create(this);
        }

        public bool actualizar()
        {
            return mDao.Update(this);
        }

        public bool eliminar()
        {
            return mDao.Delete(this);
        }
    }
}
