using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIt.Datos;

namespace TestIt.Logica
{
    class DeporteService : AbstractService<Deporte>
    {        
        public DeporteService()
        {
            this.aDao = new DeporteDao();
        }
    }
}
