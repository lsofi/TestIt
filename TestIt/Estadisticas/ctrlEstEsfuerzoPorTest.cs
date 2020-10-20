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
using TestIt.Datos;
using Microsoft.Reporting.WinForms;
using TestIt.Soporte;

namespace TestIt.Estadisticas
{
    public partial class ctrlEstEsfuerzoPorTest : UserControl
    {
        EstadisticasDao eDao = new EstadisticasDao();
        frmPrincipal fPrincipal;
        public ctrlEstEsfuerzoPorTest(frmPrincipal fp)
        {
            InitializeComponent();
            fPrincipal = fp;
        
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            rpvEsfuerzoTest.LocalReport.SetParameters(new ReportParameter[]{
                    new ReportParameter("usuario", Globals.UsuarioActual.NombreUsuario),
                    new ReportParameter("prFechaDesde", dtpDesde.Value.ToString("yyyy-MM-dd")),
                    new ReportParameter("prFechaHasta", dtpHasta.Value.ToString("yyyy-MM-dd"))});

            DataTable dt = eDao.esfuerzoTest(dtpDesde.Value.ToString("yyyy-MM-dd"), dtpHasta.Value.ToString("yyyy-MM-dd"));
            //DATASOURCE
            rpvEsfuerzoTest.LocalReport.DataSources.Clear();
            rpvEsfuerzoTest.LocalReport.DataSources.Add(new ReportDataSource("DataSetEsfuerzo", dt));
            rpvEsfuerzoTest.RefreshReport();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleListados(null);
        }
    }
}
