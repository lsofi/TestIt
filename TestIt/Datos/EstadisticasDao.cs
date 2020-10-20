using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestIt.Datos
{
    class EstadisticasDao
    {
        public DataTable evolucionDeportistas(DateTime desde, DateTime hasta, List<int> ids, int idTest, int idMedicion)
        {
            DataManager dm = DataManager.GetInstance();

            string idsList = "(" + ids[0];
            for (int i = 1; i < ids.Count; i++)
                idsList += ", " + ids[i];
            idsList += ")";

            String consulta =
                "SELECT det.valor, d.id, d.apellido, MONTH(e.fecha) AS mes" +
                " FROM deportistas d" +
                " JOIN ejecuciones e ON e.id_deportista = d.id" +
                " JOIN tests t ON e.id_test = t.id" +
                " JOIN detalle_ejecuciones det ON det.nro_ejecucion = e.nro_ejecucion" +
                " WHERE t.id = " + idTest +
                " AND d.id IN " + idsList +
                " AND det.id_campo = " + idMedicion +
                " AND e.borrado = 0 AND e.fecha BETWEEN '" + desde.ToString("yyyy-MM-dd") + "' AND '" + hasta.ToString("yyyy-MM-dd") + "'";

            return dm.ConsultaSQL(consulta);
        }

        public DataTable comparacionEquipos(int mes, int anio, List<int> idsEquipos, int idTest, List<int> idsMediciones)
        {
            DataManager dm = DataManager.GetInstance();

            string idsEquiposList = "(" + idsEquipos[0];
            for (int i = 1; i < idsEquipos.Count; i++)
                idsEquiposList += ", " + idsEquipos[i];
            idsEquiposList += ")";

            string idsMedicionesList = "(" + idsMediciones[0];
            for (int i = 1; i < idsMediciones.Count; i++)
                idsMedicionesList += ", " + idsMediciones[i];
            idsMedicionesList += ")";

            string consulta = "SELECT e.id AS id_equipo, e.nombre AS nombre_equipo, m.id AS id_campo, m.nombre AS nombre_campo, AVG(det.valor) AS valor" +
                " FROM Equipos e" +
                " JOIN Deportistas d ON d.id_equipo = e.id" +
                " JOIN Ejecuciones ej ON ej.id_deportista = d.id" +
                " JOIN Detalle_Ejecuciones det ON det.nro_ejecucion = ej.nro_ejecucion" +
                " JOIN Mediciones m ON m.id = det.id_campo" +
                " WHERE ej.id_test = " + idTest +
                " AND e.id IN " + idsEquiposList +
                " AND det.id_campo IN " + idsMedicionesList +
                " AND e.borrado = 0" +
                " AND MONTH(ej.fecha) = " + mes +
                " AND YEAR(ej.fecha) = " + anio +
                " GROUP BY e.id, e.nombre, m.id, m.nombre";

            return dm.ConsultaSQL(consulta);
        }

        internal DataTable proporcionTest(DateTime desde, DateTime hasta, int categoria, int deporte)
        {
            DataManager dm = DataManager.GetInstance();
            string consulta = "SELECT t.id, t.nombre" +
                " FROM tests t JOIN ejecuciones e ON e.id_test = t.id" +
                " JOIN deportistas d ON d.id = e.id_deportista" +
                " WHERE e.borrado = 0 AND e.fecha BETWEEN '" + desde.ToString("yyyy-MM-dd") + "' AND '" + hasta.ToString("yyyy-MM-dd") + "'";

            if (categoria != 0) consulta += " AND d.id_categoria = " + categoria;
            if (deporte != 0) consulta += " AND d.id_deporte = " + deporte;
            return dm.ConsultaSQL(consulta);
        }
        public DataTable esfuerzoTest(string desde, string hasta)
        {
            DataManager dm = DataManager.GetInstance();

            string consulta = "SELECT t.id, t.nombre, d.valor as 'cantidad' FROM Tests t" +
                " JOIN Ejecuciones e on t.id = e.id_test" +
                " JOIN Detalle_Ejecuciones d on e.nro_ejecucion = d.nro_ejecucion" +
                " JOIN Mediciones m on m.id = d.id_campo " +
                " WHERE m.nombre = 'Esfuerzo subjetivo' AND e.fecha BETWEEN '" + desde + "'AND '" + hasta + "' ";

            return dm.ConsultaSQL(consulta);

        }

    }
}
