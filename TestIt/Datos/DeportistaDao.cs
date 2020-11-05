using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIt.Logica;
using System.Data;
using System.Collections;

namespace TestIt.Datos
{
    class DeportistaDao : AbstractDao
    {
        public DeportistaDao() : base("deportistas") { }

        protected override object mappingObject(DataRow row)
        {
            Deportista oDeportista = new Deportista(Convert.ToInt32(row["id"]));

            oDeportista.Dni = Convert.ToInt32(row["dni"]);
            oDeportista.Apellido = row["apellido"].ToString();
            oDeportista.Nombre = row["nombre"].ToString();
            oDeportista.Altura = Convert.ToDouble(row["altura"]);
            oDeportista.Peso = Convert.ToDouble(row["peso"]);
            oDeportista.Sexo = Convert.ToInt32(row["sexo"]);
            oDeportista.Nacimiento = DateTime.Parse(row["fecha_nacimiento"].ToString());
            oDeportista.IdEquipo = Convert.ToInt32(row["id_equipo"]);
            oDeportista.IdDeporte = Convert.ToInt32(row["id_deporte"]);
            oDeportista.IdCategoria = Convert.ToInt32(row["id_categoria"]);
            oDeportista.Borrado = Convert.ToInt32(row["borrado"]);

            return oDeportista;
        }

        protected override void sqlCreate(object o)
        {
            Deportista oDeportista = (Deportista)o;

            string str_sql = "INSERT INTO Deportistas (dni, apellido, nombre, altura, peso, sexo, fecha_nacimiento, id_equipo, id_deporte, id_categoria, borrado)" +
                             " VALUES (" +
                              oDeportista.Dni + ", '" +
                              oDeportista.Apellido + "' , '" +
                              oDeportista.Nombre + "' ," +
                              oDeportista.Altura + ", " +
                              oDeportista.Peso + ", " +
                              oDeportista.Sexo + ", '" +
                              oDeportista.Nacimiento.ToString("yyyy-MM-dd") + "', " +
                              oDeportista.IdEquipo + ", " +
                              oDeportista.IdDeporte + ", " +
                              oDeportista.IdCategoria + ", 0)";

            DataManager.GetInstance().EjecutarSQL(str_sql);
        }

        protected override void sqlUpdate(object o)
        {
            Deportista oDeportista = (Deportista)o;

            string str_sql = "UPDATE Deportistas " +
                             "SET dni=" + oDeportista.Dni + "," +
                             "apellido= " + "'" + oDeportista.Apellido + "'" + "," +
                             "nombre= " + "'" + oDeportista.Nombre + "' ," +
                             "altura= " + oDeportista.Altura + ", " +
                             "peso= " + oDeportista.Peso + ", " +
                             "sexo= " + oDeportista.Sexo + ", " +
                             "fecha_nacimiento= '" + oDeportista.Nacimiento.ToString("yyyy-MM-dd") + "', " +
                             "id_equipo= " + oDeportista.IdEquipo + ", " +
                             "id_deporte= " + oDeportista.IdDeporte + ", " +
                             "id_categoria=" + oDeportista.IdCategoria +
                             " WHERE id=" + oDeportista.Id + " AND  borrado=0";

            DataManager.GetInstance().EjecutarSQL(str_sql);
        }

        protected override void sqlDelete(object o)
        {
            Deportista oDeportista = (Deportista)o;

            string str_sql = "UPDATE Deportistas" +
                             " SET borrado = " + 1 +
                             " WHERE id = " + oDeportista.Id;

            DataManager.GetInstance().EjecutarSQL(str_sql);
        }
    }
}
