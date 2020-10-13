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
            rpvEjecuciones.LocalReport.DataSources.Add(new ReportDataSource("DataSetListados", lDao.listadoEjecuTest(dtpDesde.Value, dtpHasta.Value, (int)cboTest.SelectedValue)));
            rpvEjecuciones.RefreshReport();
            
        }

        private void ctrlListadoEjecuTest_Load(object sender, EventArgs e)
        {
            Combo.cargarCombo(cboTest, "tests");
            cboTest.SelectedIndex = -1;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleListados(null);
        }
    }
}
