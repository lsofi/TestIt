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

namespace TestIt.Estadisticas
{
    public partial class ctrlEstProporcionTests : UserControl
    {
        EstadisticasDao eDao = new EstadisticasDao();
        frmPrincipal fPrincipal;
        bool comboOk = false;
        public ctrlEstProporcionTests(frmPrincipal fp)
        {
            InitializeComponent();
            fPrincipal = fp;
        }

        private void ctrlEstProporcionTests_Load(object sender, EventArgs e)
        {
            comboOk = false;
            Combo.cargarCombo(cboCategoria, "categorias");
            cboCategoria.SelectedIndex = -1;
            Combo.cargarCombo(cboDeporte, "deportes");
            cboDeporte.SelectedIndex = -1;
            comboOk = true;
        }

        private void btnFiltrar1_Click(object sender, EventArgs e)
        {
            if (cboDeporte.SelectedIndex == -1 || cboCategoria.SelectedIndex == -1) return;

            rpvEjecuciones.LocalReport.SetParameters(new ReportParameter[]{
                new ReportParameter("usuario", Globals.UsuarioActual.NombreUsuario),
                new ReportParameter("prFechaDesde", dtpDesde.Value.ToString("dd/MM/yyyy")),
                new ReportParameter("prFechaHasta", dtpHasta.Value.ToString("dd/MM/yyyy")),
                new ReportParameter("categoria", Categoria.buscarNombre((int)cboCategoria.SelectedValue)),
                new ReportParameter("deporte", Deporte.buscarNombre((int)cboDeporte.SelectedValue))});

            DataTable dt = eDao.proporcionTest(dtpDesde.Value, dtpHasta.Value, (int)cboCategoria.SelectedValue, (int)cboDeporte.SelectedValue);
            //DATASOURCE
            rpvEjecuciones.LocalReport.DataSources.Clear();
            rpvEjecuciones.LocalReport.DataSources.Add(new ReportDataSource("DataSetTest", dt));
            rpvEjecuciones.RefreshReport();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleListados(null);
        }

       
    }
}
