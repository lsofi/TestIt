using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIt.Entidades;
using TestIt.Datos;

namespace TestIt.Logica
{
    public class GestorUsuario
    {
        private UsuarioDB oUsuarioDB;
        public GestorUsuario()
        {
            oUsuarioDB = new UsuarioDB();
        }
        public IList<Usuario> ObtenerTodos()
        {
            return oUsuarioDB.GetAll();
        }

        public Usuario BuscarUsuario(string usuario)
        {
            return oUsuarioDB.GetUser(usuario);
        }
    }
}
