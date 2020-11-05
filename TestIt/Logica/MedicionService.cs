using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIt.Datos;

namespace TestIt.Logica
{
    class MedicionService : AbstractService<Medicion>
    {
        public MedicionService()
        {
            this.aDao = new MedicionDao();
        }

        public List<Medicion> filtrar(string nombre)
        {
            return filtrar(new Dictionary<string, dynamic> { { "nombre", nombre } });
        }

        public string buscarUnidad(int id)
        {
            return buscarCampoPorId("unidad", id);
        }
    }
}
