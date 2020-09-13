

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Data;
using TestIt.Datos;
using TestIt.Logica;

namespace TestIt.Datos
{
    public class UsuarioDao
    {
      public Usuario BuscarUsuario(string nomUsuario)
        {        
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String consultaSql = string.Concat(" SELECT id, nombre_usuario, contraseña",
                                               "  FROM Usuarios ",
                                               "  WHERE borrado=0 and nombre_usuario =  '", nomUsuario, "'");
        
            var resultado = DataManager.GetInstance().ConsultaSQL(consultaSql);

            // Validamos que el resultado tenga al menos una fila.
             if (resultado.Rows.Count > 0)
            {
                return MappingUser(resultado.Rows[0]);
            }

            return null;
        }

        private Usuario MappingUser(DataRow row)
        {
            Usuario oUsuario = new Usuario
            {
                IdUsuario = Convert.ToInt32(row["id"].ToString()),
                NombreUsuario = row["nombre_usuario"].ToString(),
                Contraseña = row.Table.Columns.Contains("contraseña") ? row["contraseña"].ToString() : null
            };

            return oUsuario;
        }
    }

}