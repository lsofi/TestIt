using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIt.Datos;

namespace TestIt.Logica
{
    class CategoriaService : AbstractService<Categoria>
    {
        public CategoriaService()
        {
            this.aDao = new CategoriaDao();
        }
    }
}
