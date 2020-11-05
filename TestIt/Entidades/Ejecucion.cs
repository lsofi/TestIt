using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIt.Datos;
using TestIt.Soporte;

namespace TestIt.Logica
{
    public class Ejecucion
    {
        private static EjecucionDao eDao = new EjecucionDao();

        private int numero;
        private int idTest;
        private int idUsuario;
        private int idDeportista;
        private DateTime fecha;
        private string observacion;
        private int borrado;
        private Dictionary<int, string> mediciones = new Dictionary<int, string>();

        public Ejecucion(int nro)
        {
            this.numero = nro;
        }
        public Ejecucion()
        {
        }

        public int Numero { get => numero; set => numero = value; }
        public int IdTest { get => idTest; set => idTest = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public int Borrado { get => borrado; set => borrado = value; }
        public int IdDeportista { get => idDeportista; set => idDeportista = value; }
        public Dictionary<int, string> Mediciones { get => mediciones; set => mediciones = value; }

        public void addMedicion(int id, string valor)
        {
            mediciones.Add(id, valor);
        }

        public void setMedicion(int id, string valor)
        {
            mediciones[id] = valor;
        }

        public string getMedicion(int id)
        {
            return mediciones[id];
        }

    }
}