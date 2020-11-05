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

namespace TestIt.Formularios.Listados
{
    public partial class ctrlListadoEjecuDeportista : UserControl
    {
        ListadosDao lDao = new ListadosDao();
        frmPrincipal fPrincipal;

        private DeportistaService sDeportista = new DeportistaService();

        public ctrlListadoEjecuDeportista(frmPrincipal fp)
        {
            InitializeComponent();
            fPrincipal = fp;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (cboDeportista.SelectedIndex == -1) return;

            Deportista deportista = sDeportista.buscarPorId((int)cboDeportista.SelectedValue);

            rpvEjecuciones.LocalReport.SetParameters(new ReportParameter[]{
                new ReportParameter("deportista", deportista.Nombre + " " + deportista.Apellido),
                new ReportParameter("usuario", Globals.UsuarioActual.NombreUsuario),
                new ReportParameter("prFechaDesde", dtpDesde.Value.ToString("dd/MM/yyyy")),
                new ReportParameter("prFechaHasta", dtpHasta.Value.ToString("dd/MM/yyyy")) }) ;

            //DATASOURCE
            rpvEjecuciones.LocalReport.DataSources.Clear();
            rpvEjecuciones.LocalReport.DataSources.Add(new ReportDataSource("DataSetListados", lDao.listadoEjecuDeportista(dtpDesde.Value, dtpHasta.Value, deportista.Id)));
            rpvEjecuciones.RefreshReport();
            
        }

        private void ctrlListadoEjecuDeportista_Load(object sender, EventArgs e)
        {
            Combo.cargarCombo(cboDeportista, "deportistas", 2);
            cboDeportista.SelectedIndex = -1;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleListados(null);
        }
    }
}
