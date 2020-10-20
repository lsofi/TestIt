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
    public partial class ctrlEstRendimientoDeportista : UserControl
    {
        EstadisticasDao eDao = new EstadisticasDao();
        frmPrincipal fPrincipal;
        private List<Deportista> lDeportistas;
        DataGridViewRow selectedRow;

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
                new ReportParameter("test", Test.buscarNombre((int)cboTest.SelectedValue)),
                new ReportParameter("usuario", Globals.UsuarioActual.NombreUsuario),
                new ReportParameter("prFechaDesde", dtpDesde.Value.ToString("dd/MM/yyyy")),
                new ReportParameter("prFechaHasta", dtpHasta.Value.ToString("dd/MM/yyyy"))}) ;

            DataTable dt = rendimientoDeportista(dtpDesde.Value, dtpHasta.Value, id, (int)cboTest.SelectedValue);
            //DATASOURCE
            rpvEjecuciones.LocalReport.DataSources.Clear();
            rpvEjecuciones.LocalReport.DataSources.Add(new ReportDataSource("DataSetRendDepo", dt));
            rpvEjecuciones.RefreshReport();
            
        }

        public DataTable rendimientoDeportista(DateTime desde, DateTime hasta, int idDep, int idTest)
        {
            DataManager dm = DataManager.GetInstance();

            String consulta =
                "SELECT m.nombre AS medicion, det.valor, 'Deportista' AS vari" +
                " FROM ejecuciones e" +
                " JOIN detalle_ejecuciones det ON det.nro_ejecucion = e.nro_ejecucion" +
                " JOIN mediciones m ON det.id_campo = m.id" +
                " WHERE e.id_test = " + idTest +
                " AND e.id_deportista = " + idDep +
                " AND e.borrado = 0 AND e.fecha BETWEEN '" + desde.ToString("yyyy-MM-dd") + "' AND '" + hasta.ToString("yyyy-MM-dd") + "'"+
                " UNION " +
                " SELECT m.nombre AS medicion, det.valor, 'Promedio' AS vari" +
                " FROM ejecuciones e" +
                " JOIN detalle_ejecuciones det ON det.nro_ejecucion = e.nro_ejecucion" +
                " JOIN mediciones m ON det.id_campo = m.id" +
                " WHERE e.id_test = " + idTest +
                " AND e.borrado = 0 AND e.fecha BETWEEN '" + desde.ToString("yyyy-MM-dd") + "' AND '" + hasta.ToString("yyyy-MM-dd") + "'";

            DataTable dt1 = dm.ConsultaSQL(consulta);

            return dt1;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleListados(null);
        }

        private void ctrlEstEvolucionDeportista_Load(object sender, EventArgs e)
        {
            Combo.cargarCombo(cboTest, "tests");
            cboTest.SelectedIndex = -1;

            lDeportistas = Deportista.buscarDeportistas();
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
