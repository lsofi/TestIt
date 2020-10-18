using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
