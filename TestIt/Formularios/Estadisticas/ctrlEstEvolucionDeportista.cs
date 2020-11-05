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
    public partial class ctrlEstEvolucionDeportista : UserControl
    {
        EstadisticasDao eDao = new EstadisticasDao();
        frmPrincipal fPrincipal;

        private MedicionService sMedicion = new MedicionService();
        private TestService sTest = new TestService();
        private DeportistaService sDeportista = new DeportistaService();

        private List<Deportista> lDeportistas;
        private List<int> idsDeportistas = new List<int>();
        bool comboOk = false;

        public ctrlEstEvolucionDeportista(frmPrincipal fp)
        {
            InitializeComponent();
            fPrincipal = fp;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (cboTest.SelectedIndex == -1 || cboMedicion.SelectedIndex == -1) return;

            int id;
            foreach (DataGridViewRow row in grdDeportistas.Rows)
            {
                if ((bool)row.Cells[2].Value)
                {
                    id = (int)row.Cells[0].Value;
                    if (!idsDeportistas.Contains(id)) idsDeportistas.Add(id);
                }
                else
                {
                    id = (int)row.Cells[0].Value;
                    if (idsDeportistas.Contains(id)) idsDeportistas.Remove(id);
                }
            }

            if (idsDeportistas.Count == 0) return;

            rpvEjecuciones.LocalReport.SetParameters(new ReportParameter[]{
                new ReportParameter("test", sTest.buscarNombre((int)cboTest.SelectedValue)),
                new ReportParameter("usuario", Globals.UsuarioActual.NombreUsuario),
                new ReportParameter("prFechaDesde", dtpDesde.Value.ToString("dd/MM/yyyy")),
                new ReportParameter("prFechaHasta", dtpHasta.Value.ToString("dd/MM/yyyy")),
                new ReportParameter("medicion", sMedicion.buscarNombre((int)cboMedicion.SelectedValue))}) ;

            DataTable dt = eDao.evolucionDeportistas(dtpDesde.Value, dtpHasta.Value, idsDeportistas, (int)cboTest.SelectedValue, (int)cboMedicion.SelectedValue);
            //DATASOURCE
            rpvEjecuciones.LocalReport.DataSources.Clear();
            rpvEjecuciones.LocalReport.DataSources.Add(new ReportDataSource("DataSetEjecuciones", dt));
            rpvEjecuciones.RefreshReport();
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleListados(null);
        }

        private void ctrlEstEvolucionDeportista_Load(object sender, EventArgs e)
        {
            comboOk = false;
            Combo.cargarCombo(cboTest, "tests");
            cboTest.SelectedIndex = -1;
            comboOk = true;

            lDeportistas = sDeportista.buscarTodos();
            grdDeportistas.Rows.Clear();
            if (lDeportistas != null)
                foreach (Deportista dep in lDeportistas)
                {
                    grdDeportistas.Rows.Add(dep.Id, dep.Nombre + " " + dep.Apellido, false);
                }
            grdDeportistas.ClearSelection();
        }

        private void cboTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboOk)
            {
                DataTable mediciones = eDao.buscarMedicionesPorTest((int)cboTest.SelectedValue);
                cboMedicion.DataSource = mediciones;
                cboMedicion.DisplayMember = mediciones.Columns[1].ColumnName;
                cboMedicion.ValueMember = mediciones.Columns[0].ColumnName;
                cboMedicion.SelectedIndex = -1;
                cboMedicion.Enabled = true;
            }
        }

        private void grdDeportistas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check to ensure that the row CheckBox is clicked.
            if (e.RowIndex >= 0)
            {
                //Reference the GridView Row.
                DataGridViewRow row = grdDeportistas.Rows[e.RowIndex];

                //Set the CheckBox selection.
                row.Cells[2].Value = !Convert.ToBoolean(row.Cells[2].EditedFormattedValue);
            }
        }
    }
}
