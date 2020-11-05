using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIt.Logica;

namespace TestIt.Datos
{
    class EjecucionDao : AbstractDao
    {
        public EjecucionDao() : base("ejecuciones") { }

        private DataTable buscarMediciones(int nro_ejecucion)
        {
            String consultaSql = "SELECT * FROM detalle_ejecuciones WHERE borrado = 0 AND nro_ejecucion = " + nro_ejecucion;
            return DataManager.GetInstance().ConsultaSQL(consultaSql);
        }

        protected override object mappingObject(DataRow row)
        {
            Ejecucion oEjecucion = new Ejecucion(Convert.ToInt32(row["nro_ejecucion"]));


            oEjecucion.IdTest = Convert.ToInt32(row["id_test"]);
            oEjecucion.IdDeportista = Convert.ToInt32(row["id_deportista"]);
            oEjecucion.Fecha = DateTime.Parse(row["fecha"].ToString());
            oEjecucion.Borrado = Convert.ToInt32(row["borrado"]);

            DataTable mediciones = buscarMediciones((int)row["nro_ejecucion"]);
            foreach (DataRow mRow in mediciones.Rows)
                oEjecucion.addMedicion((int)mRow["id_campo"], mRow["valor"].ToString());

            return oEjecucion;
        }

        protected override void sqlCreate(object o)
        {
            DataManager dm = DataManager.GetInstance();
            Ejecucion oEjecucion = (Ejecucion)o;

            string str_sql = "INSERT INTO Ejecuciones VALUES (" +
                            oEjecucion.IdTest + ", " +
                            oEjecucion.IdDeportista + ", " +
                            oEjecucion.IdUsuario + ", '" +
                            oEjecucion.Fecha.ToString("yyyy-MM-dd") + "', ";
            if (oEjecucion.Observacion == null) str_sql += "NULL";
            else str_sql += "'" + oEjecucion.Observacion + "'";
            str_sql += ", 0)";

            dm.EjecutarSQL(str_sql);
            int newId = Convert.ToInt32(dm.ConsultaSQLScalar(" SELECT @@IDENTITY"));

            foreach (int key in oEjecucion.Mediciones.Keys)
            {
                string valor = oEjecucion.Mediciones[key];
                str_sql = "INSERT INTO Detalle_Ejecuciones VALUES (" + newId + "," + key + ", ";
                if (valor == null) str_sql += "NULL";
                else str_sql += "'" + valor + "'";
                str_sql += ", 0)";

                dm.EjecutarSQL(str_sql);
            }
        }

        protected override void sqlUpdate(object o)
        {
            DataManager dm = DataManager.GetInstance();
            Ejecucion oEjecucion = (Ejecucion)o;

            foreach (int key in oEjecucion.Mediciones.Keys)
            {
                string valor = oEjecucion.Mediciones[key];
                string str_sql = "UPDATE Detalle_Ejecuciones SET valor = " + oEjecucion.Mediciones[key] +
                    " WHERE nro_ejecucion = " + oEjecucion.Numero + " AND id_campo = " + key;
                dm.EjecutarSQL(str_sql);
            }
        }

        protected override void sqlDelete(object o)
        {
            DataManager dm = DataManager.GetInstance();
            Ejecucion oEjecucion = (Ejecucion)o;

            string str_sql = "UPDATE Ejecuciones" +
                                " SET borrado = " + 1 +
                                " WHERE nro_ejecucion = " + oEjecucion.Numero;

            dm.EjecutarSQL(str_sql);

            foreach (int key in oEjecucion.Mediciones.Keys)
            {
                str_sql = "UPDATE Detalle_Ejecuciones SET borrado = 1 WHERE id_campo =" + key + " AND nro_ejecucion = " + oEjecucion.Numero;
                dm.EjecutarSQL(str_sql);
            }

        }
    }
}
