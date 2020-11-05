using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIt.Datos;

namespace TestIt.Logica
{
    class UsuarioService : AbstractService<Usuario>
    {

        public UsuarioService()
        {
            aDao = new UsuarioDao();
        }

        public Usuario buscarUsuario(string nomUsuario)
        {
            return buscarPorCampo("nombre_usuario", nomUsuario);
        }

        new public string buscarNombre(int id)
        {
            return buscarCampoPorId("nombre_usuario", id);
        }
    }
}
