using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TestIt.Logica;

namespace TestIt.Datos
{
    class MedicionDao : AbstractDao
    {
        public MedicionDao() : base("mediciones") { }

        public DataTable buscarMedicionesPorTest(int idTest)
        {
            var resultado = DataManager.GetInstance().ConsultaSQL(
                "SELECT m.id, m.nombre FROM mediciones m" +
                " JOIN medicionesXtests t ON m.id = t.id_campo " +
                " WHERE t.id_test = " + idTest);

            return resultado;
        }

        protected override object mappingObject(DataRow row)
        {
            Medicion oMedicion = new Medicion(Convert.ToInt32(row["id"]));

            oMedicion.Nombre = row["nombre"].ToString();
            oMedicion.Unidad = row["unidad"].ToString();
            oMedicion.Descripcion = row["descripcion"].ToString();
            oMedicion.Borrado = Convert.ToInt32(row["borrado"]);

            return oMedicion;
        }

        protected override void sqlCreate(object o)
        {
            Medicion oMedicion = (Medicion)o;

            string str_sql = "INSERT INTO Mediciones VALUES ('" +
                              oMedicion.Nombre + "', '" +
                              oMedicion.Unidad + "', '" +
                              oMedicion.Descripcion + "', 0)";

            DataManager.GetInstance().EjecutarSQL(str_sql);
        }

        protected override void sqlUpdate(object o)
        {
            Medicion oMedicion = (Medicion)o;

            string str_sql = "UPDATE Mediciones SET " +
                             "nombre='" + oMedicion.Nombre + "' ," +
                             "unidad= " + "'" + oMedicion.Unidad + "' ," +
                             "descripcion= " + "'" + oMedicion.Descripcion +
                             "' WHERE id=" + oMedicion.Id + " AND  borrado=0";

            DataManager.GetInstance().EjecutarSQL(str_sql);
        }

        protected override void sqlDelete(object o)
        {
            Medicion oMedicion = (Medicion)o;

            string str_sql = "UPDATE Mediciones" +
                             " SET borrado = " + 1 +
                             " WHERE id = " + oMedicion.Id;

            DataManager.GetInstance().EjecutarSQL(str_sql);
        }
    }
}
