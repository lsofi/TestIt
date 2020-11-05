using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestIt.Datos;
using TestIt.Formularios;
using TestIt.Soporte;
using Microsoft.Reporting.WinForms;

namespace TestIt.Formularios.Listados
{
    public partial class ctrlListadoEquipos : UserControl
    {
        ListadosDao lDao = new ListadosDao();
        frmPrincipal fPrincipal;
        public ctrlListadoEquipos(frmPrincipal fp)
        {
            InitializeComponent();
            fPrincipal = fp;
        }

        private void ctrlListadoEquipos_Load(object sender, EventArgs e)
        {
            

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleListados(null);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            rpvEquipos.LocalReport.SetParameters(new ReportParameter[]{
                new ReportParameter("usuario", Globals.UsuarioActual.NombreUsuario),
                new ReportParameter("prFechaDesde", dtpDesde.Value.ToString("dd/MM/yyyy")),
                new ReportParameter("prFechaHasta", dtpHasta.Value.ToString("dd/MM/yyyy")) });

            //DATASOURCE
            rpvEquipos.LocalReport.DataSources.Add(new ReportDataSource("DataSetListados", lDao.listadoEquipos(dtpDesde.Value, dtpHasta.Value)));
            rpvEquipos.RefreshReport();
        }
    }
}
