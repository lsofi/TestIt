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
using TestIt.Datos;
using TestIt.Logica;

namespace TestIt.Listados
{
    public partial class ctrlListadoEjecuTest : UserControl
    {
        ListadosDao lDao = new ListadosDao();
        frmPrincipal fPrincipal;

        public ctrlListadoEjecuTest(frmPrincipal fp)
        {
            InitializeComponent();
            fPrincipal = fp;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (cboTest.SelectedIndex == -1) return;

            rpvEjecuciones.LocalReport.SetParameters(new ReportParameter[]{
                new ReportParameter("test", Test.buscarNombre((int)cboTest.SelectedValue)),
                new ReportParameter("usuario", Globals.UsuarioActual.NombreUsuario),
                new ReportParameter("prFechaDesde", dtpDesde.Value.ToString("dd/MM/yyyy")),
                new ReportParameter("prFechaHasta", dtpHasta.Value.ToString("dd/MM/yyyy")) }) ;

            //DATASOURCE
            rpvEjecuciones.LocalReport.DataSources.Clear();
            rpvEjecuciones.LocalReport.DataSources.Add(new ReportDataSource("DataSetListados", listadoEjecuTest(dtpDesde.Value, dtpHasta.Value, (int)cboTest.SelectedValue)));
            rpvEjecuciones.RefreshReport();
            
        }

        public DataTable listadoEjecuTest(DateTime desde, DateTime hasta, int id)
        {
            DataManager dm = DataManager.GetInstance();
            String consulta =
                "SELECT e.nro_ejecucion, t.nombre AS test, d.apellido AS deportista, u.nombre_usuario AS usuario, e.fecha, e.observacion" +
                " FROM ejecuciones e" +
                " JOIN deportistas d ON e.id_deportista = d.id" +
                " JOIN tests t ON e.id_test = t.id" +
                " JOIN usuarios u ON e.id_usuario = u.id" +
                " WHERE e.borrado = 0 AND e.id_test = " + id + 
                " AND e.fecha BETWEEN '" + desde.ToString("yyyy-MM-dd") + "' AND '" + hasta.ToString("yyyy-MM-dd") + "'";

            return dm.ConsultaSQL(consulta);
        }

        private void ctrlListadoEjecuTest_Load(object sender, EventArgs e)
        {
            Combo.cargarCombo(cboTest, "tests");
            cboTest.SelectedIndex = -1;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleEjecuciones(null);
        }
    }
}
