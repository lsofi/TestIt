using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIt.Datos;

namespace TestIt.Logica
{
    class Deporte
    {
        private int id;
        private string nombre;
        private int borrado;

        public Deporte(int id)
        {
            this.id = id;
        }
        public Deporte()
        {
        }

        public int Id { get => id; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Borrado { get => borrado; set => borrado = value; }
    }
}
