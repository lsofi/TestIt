using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIt.Datos;

namespace TestIt.Logica
{
    class Deportista
    {
        private static DeportistaDao dDao = new DeportistaDao();

        private int id;
        private int dni;
        private string apellido;
        private string nombre;
        private double altura;
        private double peso;
        private int sexo;
        private DateTime nacimiento;
        private int idEquipo, idDeporte, idCategoria;
        private int borrado;

        public Deportista(int id)
        {
            this.id = id;
        }
        public Deportista()
        {
        }

        public int Id { get => id; }
        public int Dni { get => dni; set => dni = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Altura { get => altura; set => altura = value; }
        public double Peso { get => peso; set => peso = value; }
        public int Sexo { get => sexo; set => sexo = value; }
        public DateTime Nacimiento { get => nacimiento; set => nacimiento = value; }
        public int IdEquipo { get => idEquipo; set => idEquipo = value; }
        public int IdDeporte { get => idDeporte; set => idDeporte = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public int Borrado { get => borrado; set => borrado = value; }

        public static List<Deportista> buscarDeportistas()
        {
            return dDao.buscarDeportistas();
        }

        public static List<Deportista> filtrarDeportistas(string apellido, int equipo, int deporte, int categoria)
        {
            return dDao.filtrarDeportistas(apellido, equipo, deporte, categoria);
        }

        public static int buscarId(string nombre)
        {
            return dDao.getId(nombre);
        }

        public static Deportista buscarPorId(int id)
        {
            return dDao.getFromId(id);
        }

        public static string buscarApellido(int id)
        {
            return dDao.getApellido(id);
        }

        public bool grabar()
        {
            return dDao.Create(this);
        }

        public bool actualizar()
        {
            return dDao.Update(this);
        }

        public bool eliminar()
        {
            return dDao.Delete(this);
        }
    }
}
