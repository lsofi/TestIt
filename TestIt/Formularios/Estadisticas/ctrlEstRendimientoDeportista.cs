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

namespace TestIt.Formularios.Estadisticas
{
    public partial class ctrlEstRendimientoDeportista : UserControl
    {
        EstadisticasDao eDao = new EstadisticasDao();
        frmPrincipal fPrincipal;
        private List<Deportista> lDeportistas;
        DataGridViewRow selectedRow;

        private TestService sTest = new TestService();
        private DeportistaService sDeportista = new DeportistaService();

        public ctrlEstRendimientoDeportista(frmPrincipal fp)
        {
            InitializeComponent();
            fPrincipal = fp;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (cboTest.SelectedIndex == -1) return;

            int id = -1;
            foreach (DataGridViewRow row in grdDeportistas.Rows)
            {
                if ((bool)row.Cells[2].Value)
                {
                    id = (int)row.Cells[0].Value;
                    break;
                }
            }

            if (id == -1) return;

            rpvEjecuciones.LocalReport.SetParameters(new ReportParameter[]{
                new ReportParameter("deportista", selectedRow.Cells[1].Value.ToString()),
                new ReportParameter("test", sTest.buscarNombre((int)cboTest.SelectedValue)),
                new ReportParameter("usuario", Globals.UsuarioActual.NombreUsuario),
                new ReportParameter("prFechaDesde", dtpDesde.Value.ToString("dd/MM/yyyy")),
                new ReportParameter("prFechaHasta", dtpHasta.Value.ToString("dd/MM/yyyy"))}) ;

            DataTable dt = eDao.rendimientoDeportista(dtpDesde.Value, dtpHasta.Value, id, (int)cboTest.SelectedValue);
            //DATASOURCE
            rpvEjecuciones.LocalReport.DataSources.Clear();
            rpvEjecuciones.LocalReport.DataSources.Add(new ReportDataSource("DataSetRendDepo", dt));
            rpvEjecuciones.RefreshReport();
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleListados(null);
        }

        private void ctrlEstEvolucionDeportista_Load(object sender, EventArgs e)
        {
            Combo.cargarCombo(cboTest, "tests");
            cboTest.SelectedIndex = -1;

            lDeportistas = sDeportista.buscarTodos();
            grdDeportistas.Rows.Clear();
            if (lDeportistas != null)
                foreach (Deportista dep in lDeportistas)
                {
                    grdDeportistas.Rows.Add(dep.Id, dep.Nombre + " " + dep.Apellido, false);
                }
            grdDeportistas.ClearSelection();
        }

        private void grdDeportistas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check to ensure that the row CheckBox is clicked.
            if (e.RowIndex >= 0)
            {
                //Reference the GridView Row.
                DataGridViewRow row = grdDeportistas.Rows[e.RowIndex];

                if (selectedRow != null) selectedRow.Cells[2].Value = false;
                row.Cells[2].Value = true;

                selectedRow = row;
            }
        }
    }
}
