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
    public partial class ctrlEstComparacionEquipos : UserControl
    {
        EstadisticasDao eDao = new EstadisticasDao();
        frmPrincipal fPrincipal;
        private List<Equipo> lEquipos;
        private List<int> idsEquipos = new List<int>();

        List<int> idMediciones = new List<int>();
        bool comboOk = false;

        public ctrlEstComparacionEquipos(frmPrincipal fp)
        {
            InitializeComponent();
            fPrincipal = fp;
        }

        private void ctrlEstComparacionEquipos_Load(object sender, EventArgs e)
        {
            comboOk = false;
            Combo.cargarCombo(cboTest, "tests");
            cboTest.SelectedIndex = -1;
            comboOk = true;

            lEquipos = Equipo.buscarEquipos();
            grdEquipos.Rows.Clear();
            if (lEquipos != null)
                foreach (Equipo eq in lEquipos)
                {
                    grdEquipos.Rows.Add(eq.Id, eq.Nombre, false);
                }
            grdEquipos.ClearSelection();
        }


        private void cboTest_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboOk)
            {
                DataTable resultado = Medicion.buscarMedicionesPorTest((int)cboTest.SelectedValue);

                if (resultado.Rows.Count > 0)
                {
                    foreach (DataRow row in resultado.Rows)
                    {
                        idMediciones.Add((int)row["id"]);
                    }
                }
            }
        }

        private void grdEquipos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check to ensure that the row CheckBox is clicked.
            if (e.RowIndex >= 0)
            {
                //Reference the GridView Row.
                DataGridViewRow row = grdEquipos.Rows[e.RowIndex];

                //Set the CheckBox selection.
                row.Cells[2].Value = !Convert.ToBoolean(row.Cells[2].EditedFormattedValue);
            }
        }

        private void btnFiltrar_Click_1(object sender, EventArgs e)
        {
            if (cboTest.SelectedIndex == -1) return;

            int id;
            foreach (DataGridViewRow row in grdEquipos.Rows)
            {
                if ((bool)row.Cells[2].Value)
                {
                    id = (int)row.Cells[0].Value;
                    if (!idsEquipos.Contains(id)) idsEquipos.Add(id);
                }
                else
                {
                    id = (int)row.Cells[0].Value;
                    if (idsEquipos.Contains(id)) idsEquipos.Remove(id);
                }
            }

            if (idsEquipos.Count == 0) return;

            rpvEjecuciones.LocalReport.SetParameters(new ReportParameter[]{
                    new ReportParameter("test", Test.buscarNombre((int)cboTest.SelectedValue)),
                    new ReportParameter("usuario", Globals.UsuarioActual.NombreUsuario),
                    new ReportParameter("mes", dtpMes.Value.Month.ToString()),
                    new ReportParameter("anio", dtpAnio.Value.Year.ToString())});

            DataTable dt = eDao.comparacionEquipos(dtpMes.Value.Month, dtpAnio.Value.Year, idsEquipos, (int)cboTest.SelectedValue, idMediciones);
            //DATASOURCE
            rpvEjecuciones.LocalReport.DataSources.Clear();
            rpvEjecuciones.LocalReport.DataSources.Add(new ReportDataSource("DataSetEjecEquipos", dt));
            rpvEjecuciones.RefreshReport();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleListados(null);
        }
    }
}
