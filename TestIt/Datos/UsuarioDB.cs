

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
using TestIt.Entidades;
using System.Data;

namespace TestIt.Datos
{
    public class UsuarioDB
    {
        public IList<Usuario> GetAll()
        {
            List<Usuario> listadoUsuarios = new List<Usuario>();

            var strSql = "SELECT id, nombre_usuario, contraseña FROM Usuarios WHERE borrado=0";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoUsuarios.Add(MappingUser(row));
            }

            return listadoUsuarios;
        }

        public Usuario GetUser(string pUsuario)
        {        
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String consultaSql = string.Concat(" SELECT id, nombre_usuario, contraseña",
                                               "  FROM Usuarios ",
                                               "  WHERE borrado=0 and nombre_usuario =  '", pUsuario, "'");

            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSql);

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