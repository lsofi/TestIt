using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIt.Datos;

namespace TestIt.Logica
{
    class EquipoService : AbstractService<Equipo>
    {
        public EquipoService()
        {
            this.aDao = new EquipoDao();
        }

        public List<Equipo> filtrar(string nombre, string localidad)
        {
            return filtrar(new Dictionary<string, dynamic> { { "nombre", nombre }, { "localidad", localidad } });
        }
    }
}
