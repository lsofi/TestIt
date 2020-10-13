using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIt.Datos;

namespace TestIt.Logica
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }

        public static Usuario buscarUsuario(string nomUsuario)
        {
            UsuarioDao ud = new UsuarioDao();
            return ud.BuscarUsuario(nomUsuario);
        }

        public bool ValidarContraseña(string password)
        {
            return (Contraseña != null && Contraseña.Equals(password));
        }

        public override string ToString()
        {
            return NombreUsuario;
        }

        public static string buscarNombre(int id)
        {
            UsuarioDao ud = new UsuarioDao();
            return ud.getNombre(id);
        }
    }
}
