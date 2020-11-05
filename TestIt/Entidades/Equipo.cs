using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIt.Datos;

namespace TestIt.Logica
{
    class Equipo
    {
        private static EquipoDao eDao = new EquipoDao();

        private int id;
        private string nombre;
        private string localidad;
        private string entrenador;
        private int borrado;

        public Equipo(int id)
        {
            this.id = id;
        }
        public Equipo()
        {
        }

        public int Id { get => id;}
        public string Nombre { get => nombre; set => nombre = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public string Entrenador { get => entrenador; set => entrenador = value; }
        public int Borrado { get => borrado; set => borrado = value; }
    }
}
