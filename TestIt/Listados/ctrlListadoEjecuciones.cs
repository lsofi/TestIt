using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestIt.Formularios;
using Microsoft.Reporting.WinForms;
using TestIt.Soporte;

namespace TestIt.Listados
{
    public partial class ctrlListadoEjecuciones : UserControl
    {
        public ctrlListadoEjecuciones()
        {
            InitializeComponent();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

            rpvEjecuciones.LocalReport.SetParameters(new ReportParameter[]{
                new ReportParameter("usuario", Globals.UsuarioActual.NombreUsuario),
                new ReportParameter("prFechaDesde", dtpDesde.Value.ToString("dd/MM/yyyy")),
                new ReportParameter("prFechaHasta", dtpHasta.Value.ToString("dd/MM/yyyy")) }) ;

            //DATASOURCE
            rpvEjecuciones.LocalReport.DataSources.Clear();
            rpvEjecuciones.LocalReport.DataSources.Add(new ReportDataSource("DataSetTestIt", generarListado(dtpDesde.Value, dtpHasta.Value)));
            rpvEjecuciones.RefreshReport();
            
        }

        private DataTable generarListado(DateTime desde, DateTime hasta)
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
    }
}
