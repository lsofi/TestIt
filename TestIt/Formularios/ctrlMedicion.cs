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
    public partial class ctrlMedicion : UserControl
    {
        private frmPrincipal fPrincipal;

        private List<Medicion> lMedicion;
        private bool nuevo = false;

        public ctrlMedicion(frmPrincipal fp)
        {
            InitializeComponent();
            fPrincipal = fp;
        }

        private void ctrlMedicion_Load(object sender, EventArgs e)
        {
            lMedicion = Medicion.buscarMediciones();
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            grdMediciones.Rows.Clear();
            if (lMedicion != null)
                foreach (Medicion medicion in lMedicion)
                {
                    grdMediciones.Rows.Add(medicion.Id, medicion.Nombre);
                }
            grdMediciones.ClearSelection();
        }

        private void grdMediciones_SelectionChanged(object sender, EventArgs e)
        {
            if (grdMediciones.SelectedRows.Count == 0)
                limpiarCampos();
            else
                cargarCampos();
        }


        private void toggleEdit(bool edit)
        {
            btnAceptar.Enabled = edit;
            btnCancelar.Enabled = edit;
            btnAgregar.Enabled = !edit;
            btnEditar.Enabled = !edit;
            btnEliminar.Enabled = !edit;

            txtNombre.Enabled = !edit;

            txtDetNombre.Enabled = edit;
            txtUnidad.Enabled = edit;
            txtDescripcion.Enabled = edit;

            grdMediciones.Enabled = !edit;
        }

        private void cargarCampos()
        {
            Medicion medicion = medicionActual();

            txtDetNombre.Text = medicion.Nombre;
            txtUnidad.Text = medicion.Unidad;
            txtDescripcion.Text = medicion.Descripcion;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void limpiarCampos()
        {
            txtDetNombre.Text = "";
            txtUnidad.Text = "";
            txtDescripcion.Text = "";
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private Medicion medicionActual()
        {
            foreach (Medicion medicion in lMedicion)
                if (medicion.Id == (int)grdMediciones.SelectedRows[0].Cells[0].Value)
                    return medicion;
            return null;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void filtrar()
        {
            lMedicion = Medicion.filtrarMediciones(txtNombre.Text);
            cargarGrilla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            nuevo = true;
            grdMediciones.ClearSelection();
            toggleEdit(true);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            toggleEdit(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Medicion actual = medicionActual();
            DialogResult answer = MessageBox.Show(
                "¿Desea eliminar la medicion " + actual.Nombre + "?",
                "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (answer == DialogResult.Yes)
            {
                if (actual.eliminar())
                {
                    filtrar();
                    MessageBox.Show("Medicion eliminada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Error al eliminar medicion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (validarCampos())
            {
                
                Medicion medicion = nuevo ? new Medicion() : medicionActual();
                medicion.Nombre = txtDetNombre.Text;
                medicion.Unidad = txtUnidad.Text;
                medicion.Descripcion = txtDescripcion.Text == null ? " " : txtDescripcion.Text; 

                if (nuevo)
                {
                    medicion.Borrado = 0;

                    if (medicion.grabar())
                    {
                        filtrar();
                        MessageBox.Show("Medicion grabada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Error al grabar Medicion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nuevo = false;
                }
                else
                {
                    if (medicion.actualizar())
                    {
                        filtrar();
                        MessageBox.Show("Medicion actualizada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Error al actualizar medicion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                toggleEdit(false);
            }
            else
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarCampos();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            nuevo = false;
            toggleEdit(false);
            limpiarCampos();
            grdMediciones.ClearSelection();
        }

        private bool validarCampos()
        {
            if (txtDetNombre.Text == "") return false;
            if (txtUnidad.Text == "") return false;
            return true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleMediciones();
        }
    }
}
