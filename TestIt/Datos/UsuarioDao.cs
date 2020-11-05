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
    class UsuarioDao : AbstractDao
    {
        public UsuarioDao() : base("usuarios") { }

      public Usuario BuscarUsuario(string nomUsuario)
        {        
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            string str_sql = "SELECT id, nombre_usuario, contraseña" +
                             " FROM Usuarios " +
                             " WHERE borrado=0 and nombre_usuario =  '" + nomUsuario + "'";
        
            var resultado = DataManager.GetInstance().ConsultaSQL(str_sql);

            // Validamos que el resultado tenga al menos una fila.
             if (resultado.Rows.Count > 0)
            {
                return (Usuario) mappingObject(resultado.Rows[0]);
            }

            return null;
        }

        protected override object mappingObject(DataRow row)
        {
            Usuario oUsuario = new Usuario
            {
                IdUsuario = Convert.ToInt32(row["id"].ToString()),
                NombreUsuario = row["nombre_usuario"].ToString(),
                Contraseña = row.Table.Columns.Contains("contraseña") ? row["contraseña"].ToString() : null
            };

            return oUsuario;
        }

        protected override void sqlCreate(object o)
        {
            throw new NotImplementedException();
        }

        protected override void sqlDelete(object o)
        {
            throw new NotImplementedException();
        }

        protected override void sqlUpdate(object o)
        {
            throw new NotImplementedException();
        }
    }

}