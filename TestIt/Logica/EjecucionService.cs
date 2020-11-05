using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIt.Datos;

namespace TestIt.Logica
{
    class EjecucionService : AbstractService<Ejecucion>
    {
        public EjecucionService()
        {
            aDao = new EjecucionDao();
        }

        public List<Ejecucion> filtrar(int test, int deportista, DateTime fechaDesde, DateTime fechaHasta)
        {
            return filtrar(new Dictionary<string, dynamic> {
                { "id_test", test }, 
                { "id_deportista", deportista }, 
                { "desde", fechaDesde }, 
                { "hasta", fechaHasta }});
        }
    }
}
