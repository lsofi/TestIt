using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIt.Logica;
using System.Data;

namespace TestIt.Datos
{
    class EquipoDao : AbstractDao
    {
        public EquipoDao() : base("equipos") { }

        protected override object mappingObject(DataRow row)
        {
            Equipo oEquipo = new Equipo(Convert.ToInt32(row["id"]));

            oEquipo.Nombre = row["nombre"].ToString();
            oEquipo.Localidad = row["localidad"].ToString();
            oEquipo.Entrenador = row["entrenador"].ToString();
            oEquipo.Borrado = Convert.ToInt32(row["borrado"]);

            return oEquipo;
        }

        protected override void sqlCreate(object o)
        {
            Equipo oEquipo = (Equipo)o;

            string str_sql = "INSERT INTO Equipos VALUES ('" +
                              oEquipo.Nombre + "', '" +
                              oEquipo.Localidad + "' , '" +
                              oEquipo.Entrenador + "', 0)";

            DataManager.GetInstance().EjecutarSQL(str_sql);
        }

        protected override void sqlUpdate(object o)
        {
            Equipo oEquipo = (Equipo)o;

            string str_sql = "UPDATE Equipos SET " +
                             "nombre='" + oEquipo.Nombre + "'," +
                             "localidad= " + "'" + oEquipo.Localidad + "'," +
                             "entrenador= '" + oEquipo.Entrenador +
                             "' WHERE id=" + oEquipo.Id + " AND  borrado=0";

            DataManager.GetInstance().EjecutarSQL(str_sql);
        }

        protected override void sqlDelete(object o)
        {
            Equipo oEquipo = (Equipo)o;

            string str_sql = "UPDATE Equipos" +
                             " SET borrado = " + 1 +
                             " WHERE id = " + oEquipo.Id;

            DataManager.GetInstance().EjecutarSQL(str_sql);
        }
    }
}
