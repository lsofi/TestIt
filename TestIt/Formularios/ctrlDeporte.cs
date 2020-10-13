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
    public partial class ctrlDeporte : UserControl
    {
        private List<Deporte> lDeportes;
        private bool nuevo = false;
        public ctrlDeporte()
        {
            InitializeComponent();
        }

        private void ctrlDeporte_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            grdDeporte.Rows.Clear();
            lDeportes = Deporte.buscarDeporte();
            foreach (Deporte deporte in lDeportes)
            {
                grdDeporte.Rows.Add(deporte.Id, deporte.Nombre);
            }
            grdDeporte.ClearSelection();
        }

        private void toggleEdit(bool edit)
        {
            btnAceptar.Enabled = edit;
            btnCancelar.Enabled = edit;
            btnAgregar.Enabled = !edit;
            btnEditar.Enabled = !edit;
            btnEliminar.Enabled = !edit;

            txtNombreDet.Enabled = edit;

            grdDeporte.Enabled = !edit;
        }
        private void grdDeporte_SelectionChanged(object sender, EventArgs e)
        {
            if (grdDeporte.SelectedRows.Count == 0)
                limpiarCampos();
            else
                cargarCampos();
        }

        private void cargarCampos()
        {
            Deporte deporte = deporteActual();

            txtNombreDet.Text = deporte.Nombre;

            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void limpiarCampos()
        {
            txtNombreDet.Text = "";
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }
        private Deporte deporteActual()
        {
            foreach (Deporte deporte in lDeportes)
                if (deporte.Id == (int)grdDeporte.SelectedRows[0].Cells[0].Value)
                    return deporte;
            return null;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            nuevo = true;
            grdDeporte.ClearSelection();
            toggleEdit(true);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            toggleEdit(true);
        }


        private bool validarCampos()
        {
            if (txtNombreDet.Text == "") return false;
            return true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Deporte actual = deporteActual();
            DialogResult answer = MessageBox.Show(
                "¿Desea eliminar el deporte " + actual.Nombre + "?",
                "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (answer == DialogResult.Yes)
            {
                if (actual.eliminar())
                {
                    MessageBox.Show("Deporte eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarGrilla();
                }
                else
                    MessageBox.Show("Error al eliminar deporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                Deporte deporte = nuevo ? new Deporte() : deporteActual();
                deporte.Nombre = txtNombreDet.Text;

                if (nuevo)
                {
                    deporte.Borrado = 0;

                    if (deporte.grabar())
                    {
                        MessageBox.Show("Deporte grabado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lDeportes = Deporte.buscarDeporte();
                        cargarGrilla();
                    }
                    else
                        MessageBox.Show("Error al grabar Deporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nuevo = false;
                }
                else
                {
                    if (deporte.actualizar())
                    {
                        MessageBox.Show("Deporte actualizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lDeportes = Deporte.buscarDeporte();
                        cargarGrilla();
                    }
                    else
                        MessageBox.Show("Error al actualizar deporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                toggleEdit(false);
            }
            else
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            nuevo = false;
            toggleEdit(false);
            grdDeporte.ClearSelection();

        }
        
    }
}
