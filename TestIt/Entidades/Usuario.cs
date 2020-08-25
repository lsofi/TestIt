using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIt.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }

        public bool ValidarContraseña(string password)
        {
            return (Contraseña != null && Contraseña.Equals(password));
        }

        public override string ToString()
        {
            return NombreUsuario;
        }
    }
}
