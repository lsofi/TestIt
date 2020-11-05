using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIt.Datos;

namespace TestIt.Logica
{
    class TestService : AbstractService<Test>
    {
        public TestService()
        {
            this.aDao = new TestDao();
        }

        public List<Test> filtrar(string nombre)
        {
            return filtrar(new Dictionary<string, dynamic> { { "nombre", nombre } });
        }
    }
}
