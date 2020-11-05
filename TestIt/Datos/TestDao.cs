using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIt.Logica;
using System.Data;

namespace TestIt.Datos
{
    class TestDao : AbstractDao
    {
        public TestDao() : base("tests") { }

        private List<int> buscarIdMediciones(int testId)
        {
            String consultaSql = string.Concat("SELECT id_campo FROM medicionesxTests WHERE id_test = " + testId);

            var resultado = DataManager.GetInstance().ConsultaSQL(consultaSql);

            List<int> idMediciones = new List<int>();

            if (resultado.Rows.Count > 0)
            {
                foreach (DataRow row in resultado.Rows)
                {
                    idMediciones.Add((int)row["id_campo"]);
                }            
            }
            return idMediciones;
        }

        protected override object mappingObject(DataRow row)
        {
            Test oTest = new Test(Convert.ToInt32(row["id"]));

            oTest.Nombre = row["nombre"].ToString();
            oTest.Descripcion = row["descripcion"].ToString();
            oTest.Borrado = Convert.ToInt32(row["borrado"]);
            oTest.IdMediciones = buscarIdMediciones((int)row["id"]);

            return oTest;
        }

        protected override void sqlCreate(object o)
        {
            DataManager dm = DataManager.GetInstance();
            Test oTest = (Test)o;

            string str_sql = "INSERT INTO Tests VALUES ('" +
                            oTest.Nombre + "', '" +
                            oTest.Descripcion + "', 0)";

            dm.EjecutarSQL(str_sql);
            int newId = Convert.ToInt32(dm.ConsultaSQLScalar(" SELECT @@IDENTITY"));

            foreach (int idMedicion in oTest.IdNuevas)
            {
                str_sql = "INSERT INTO MedicionesXTests VALUES (" + idMedicion + "," + newId + ",0)";
                dm.EjecutarSQL(str_sql);
            }
        }

        protected override void sqlUpdate(object o)
        {
            DataManager dm = DataManager.GetInstance();
            Test oTest = (Test)o;

            string str_sql = "UPDATE Tests SET " +
                              "nombre='" + oTest.Nombre + "' ," +
                              "descripcion= " + "'" + oTest.Descripcion +
                              "' WHERE id=" + oTest.Id + " AND  borrado=0";

            dm.EjecutarSQL(str_sql);

            foreach (int idMedicion in oTest.IdNuevas)
            {
                str_sql = "INSERT INTO MedicionesXTests VALUES (" + idMedicion + "," + oTest.Id + ",0)";
                dm.EjecutarSQL(str_sql);
            }

            foreach (int idMedicion in oTest.IdEliminadas)
            {
                str_sql = "DELETE FROM MedicionesXTests WHERE id_campo =" + idMedicion + " AND id_test = " + oTest.Id;
                dm.EjecutarSQL(str_sql);
            }
        }

        protected override void sqlDelete(object o)
        {
            DataManager dm = DataManager.GetInstance();
            Test oTest = (Test)o;

            string str_sql = "UPDATE Tests" +
                                " SET borrado = " + 1 +
                                " WHERE id = " + oTest.Id;

            dm.EjecutarSQL(str_sql);

            foreach (int idMedicion in oTest.IdMediciones)
            {
                str_sql = "UPDATE MedicionesXTests SET borrado = 1 WHERE id_campo =" + idMedicion + " AND id_test = " + oTest.Id;
                dm.EjecutarSQL(str_sql);
            }
        }
    }
}
