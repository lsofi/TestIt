using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIt.Datos
{
    class ListadosDao
    {
        public DataTable listadoEjecuciones(DateTime desde, DateTime hasta)
        {
            DataManager dm = DataManager.GetInstance();
            String consulta =
                "SELECT e.nro_ejecucion, t.nombre AS test, d.apellido AS deportista, u.nombre_usuario AS usuario, e.fecha, e.observacion" +
                " FROM ejecuciones e" +
                " JOIN deportistas d ON e.id_deportista = d.id" +
                " JOIN tests t ON e.id_test = t.id" +
                " JOIN usuarios u ON e.id_usuario = u.id" +
                " WHERE e.borrado = 0 AND e.fecha BETWEEN '" + desde.ToString("yyyy-MM-dd") + "' AND '" + hasta.ToString("yyyy-MM-dd") + "'";

            return dm.ConsultaSQL(consulta);
        }

        public DataTable listadoCategorias(DateTime desde, DateTime hasta)
        {
            DataManager dm = DataManager.GetInstance();
            String consulta =
                "SELECT c.nombre, c.edad_min, c.edad_max, COUNT(*) AS cant_ejecuciones" +
                " FROM ejecuciones e JOIN usuarios u ON u.id = e.id_usuario" +
                " JOIN deportistas d ON d.id = e.id_deportista" +
                " JOIN categorias c ON c.id = d.id_categoria" +
                " WHERE e.borrado = 0 AND" +
                " e.fecha BETWEEN '" + desde.ToString("yyyy-MM-dd") + "' AND '" + hasta.ToString("yyyy-MM-dd") + "'" +
                " GROUP BY c.nombre, c.edad_min, c.edad_max";
            return dm.ConsultaSQL(consulta);
        }
    }
}
