using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestIt.Logica;
using TestIt.Soporte;

namespace TestIt.Formularios
{
    public partial class ctrlEjecucion : UserControl
    {
        private frmPrincipal fPrincipal;

        private List<Ejecucion> lEjecuciones;

        public ctrlEjecucion(frmPrincipal fp)
        {
            InitializeComponent();
            fPrincipal = fp;
        }

        private void ctrlEjecucion_Load(object sender, EventArgs e)
        {
            cargarDatos();
            cargarCombos();
        }

        private void cargarCombos()
        {
            Combo.cargarCombo(cboTest, "Tests");
            Combo.cargarCombo(cboDeportista, "Deportistas", 2);
        }

        private void cargarGrilla()
        {
            grdEjecuciones.Rows.Clear();
            if (lEjecuciones != null)
                foreach (Ejecucion ejecucion in lEjecuciones)
                {
                    grdEjecuciones.Rows.Add(ejecucion.Numero, Test.buscarNombre(ejecucion.IdTest), Deportista.buscarApellido(ejecucion.IdDeportista), ejecucion.Fecha.ToString("dd/MM/yyyy"));
                }
            grdEjecuciones.ClearSelection();
        }

        public void cargarDatos()
        {
            lEjecuciones = Ejecucion.buscarEjecuciones();
            cargarGrilla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            filtrar();
        }

        private void filtrar()
        {
            lEjecuciones = Ejecucion.filtrarEjecuciones(
                cboTest.SelectedIndex == -1 ? -1 : (int)cboTest.SelectedValue,
                cboDeportista.SelectedIndex == -1 ? -1 : (int)cboDeportista.SelectedValue, dtpDesde.Value, dtpHasta.Value);
            cargarGrilla();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            cboTest.SelectedIndex = -1;
            cboDeportista.SelectedIndex = -1;
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;
            cargarDatos();
        }

        private Ejecucion ejecucionActual()
        {
            foreach (Ejecucion ejecucion in lEjecuciones)
                if (ejecucion.Numero == (int)grdEjecuciones.SelectedRows[0].Cells[0].Value)
                    return ejecucion;
            return null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleEjecuciones(null);
        }

        private void grdEjecuciones_SelectionChanged(object sender, EventArgs e)
        {
            if (grdEjecuciones.SelectedRows.Count == 0)
            {
                btnDetalle.Enabled = false;
                btnEliminar.Enabled = false;
            }
            else
            {
                btnDetalle.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleEjecuciones(ejecucionActual());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Ejecucion actual = ejecucionActual();
            DialogResult answer = MessageBox.Show(
                "¿Desea eliminar la ejecución?",
                "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (answer == DialogResult.Yes)
            {
                if (actual.eliminar())
                {
                    limpiar();
                    MessageBox.Show("Ejecución eliminada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Error al eliminar ejecución", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
