using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIt.Datos;

namespace TestIt.Logica
{
    class DeportistaService : AbstractService<Deportista>
    {
        public DeportistaService()
        {
            this.aDao = new DeportistaDao();
        }

        public List<Deportista> filtrar(string apellido, int equipo, int deporte, int categoria)
        {
            return filtrar(new Dictionary<string, dynamic> {
                    { "apellido", apellido },
                    { "id_equipo", equipo },
                    { "id_deporte", deporte },
                    { "id_categoria", categoria }
                    });
        }

        public string buscarApellido(int id)
        {
            return buscarCampoPorId("apellido", id);
        }
    }
}
