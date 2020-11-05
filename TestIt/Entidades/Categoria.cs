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
    }
}
