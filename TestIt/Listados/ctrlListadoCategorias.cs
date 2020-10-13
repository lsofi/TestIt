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
    public partial class ctrlListadoCategorias : UserControl
    {
        ListadosDao lDao = new ListadosDao();
        frmPrincipal fPrincipal;
        public ctrlListadoCategorias(frmPrincipal fp)
        {
            InitializeComponent();
            fPrincipal = fp;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            rpvCategorias.LocalReport.SetParameters(new ReportParameter[]{
                new ReportParameter("usuario", Globals.UsuarioActual.NombreUsuario),
                new ReportParameter("prFechaDesde", dtpDesde.Value.ToString("dd/MM/yyyy")),
                new ReportParameter("prFechaHasta", dtpHasta.Value.ToString("dd/MM/yyyy")) });

            //DATASOURCE
            rpvCategorias.LocalReport.DataSources.Clear();
            rpvCategorias.LocalReport.DataSources.Add(new ReportDataSource("DataSetListados", lDao.listadoCategorias(dtpDesde.Value, dtpHasta.Value)));
            rpvCategorias.RefreshReport();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleListados(null);
        }
    }
}
