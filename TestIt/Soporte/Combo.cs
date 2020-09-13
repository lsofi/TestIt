using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using TestIt.Datos;

namespace TestIt.Soporte
{
    class Combo
    {
        static public void cargarCombo(ComboBox combo, string nomTabla, int campo = 1)
        {
            DataTable tabla = new DataTable();
            tabla = DataManager.GetInstance().ConsultaSQL("SELECT * FROM " + nomTabla + " WHERE borrado=0");
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[campo].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = -1;
        }
    }
}
