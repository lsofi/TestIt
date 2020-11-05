using System;
using System.Collections.Generic;
using System.Data;
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
 
    }
}
