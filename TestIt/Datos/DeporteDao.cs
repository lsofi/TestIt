 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIt.Logica;
using System.Data;

namespace TestIt.Datos
{
    class DeporteDao : AbstractDao
    {
        public DeporteDao() : base("deportes") { }

        protected override object mappingObject(DataRow row)
        {
            Deporte oDeporte = new Deporte(Convert.ToInt32(row["id"]));

            oDeporte.Nombre = row["nombre"].ToString();
            oDeporte.Borrado = Convert.ToInt32(row["borrado"]);
            return oDeporte;
        }

        protected override void sqlCreate(object o)
        {
            Deporte oDeporte = (Deporte)o;

            string str_sql = "INSERT INTO Deportes VALUES ('" +
                              oDeporte.Nombre + "', 0)";

            DataManager.GetInstance().EjecutarSQL(str_sql);
        }

        protected override void sqlUpdate(object o)
        {
            Deporte oDeporte = (Deporte)o;

            string str_sql = "UPDATE Deportes SET " +
                             "nombre='" + oDeporte.Nombre + "'" +
                             "WHERE id= " + oDeporte.Id + " AND  borrado=0";

            DataManager.GetInstance().EjecutarSQL(str_sql);
        }

        protected override void sqlDelete(object o)
        {
            Deporte oDeporte = (Deporte)o;

            string str_sql = "UPDATE Deportes " +
                             "SET borrado = " + 1 +
                             " WHERE id = " + oDeporte.Id;

            DataManager.GetInstance().EjecutarSQL(str_sql);
        }
    }
}

