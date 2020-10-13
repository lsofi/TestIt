using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIt.Datos;

namespace TestIt.Logica
{
    class Test
    {
        private static TestDao tDao = new TestDao();

        private int id;
        private string nombre;
        private string descripcion;
        private List<int> idMediciones = new List<int>();
        private List<int> idNuevas = new List<int>();
        private List<int> idEliminadas = new List<int>();
        private int borrado;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; } 
        public List<int> IdMediciones { get => idMediciones; set => idMediciones = value; }
        public List<int> IdNuevas { get => idNuevas;  }
        public List<int> IdEliminadas { get => idEliminadas; }
        public int Borrado { get => borrado; set => borrado = value; }

        public Test(int id)
        {
            this.id = id;
        }

        public Test()
        {
        }

        public void addMedicion(int id)
        {
            if (!idMediciones.Contains(id))
                idNuevas.Add(id);
        }

        public void removeMedicion(int id)
        {
            if (idMediciones.Contains(id))
                idEliminadas.Add(id);
        }


        public static List<Test> buscarTests()
        {
            return tDao.buscarTests();
        }

        public static Test buscarTestPorId (int id)
        {
            return tDao.buscarTestPorId(id);
        }

        public static List<Test> filtrarTests(string nombre)
        {
            return tDao.filtrarTests(nombre);
        }

        public static int buscarId(string nombre)
        {
            return tDao.getId(nombre);
        }

        public static string buscarNombre(int id)
        {
            return tDao.getNombre(id);
        }

        public bool grabar()
        {
            return tDao.Create(this);
        }

        public bool actualizar()
        {
            return tDao.Update(this);
        }

        public bool eliminar()
        {
            return tDao.Delete(this);
        }
    }
}
