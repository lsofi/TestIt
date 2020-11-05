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
    public partial class ctrlEquipo : UserControl
    {
        private EquipoService sEquipo = new EquipoService();
        private List<Equipo> lEquipos;
        private bool nuevo = false;

        public ctrlEquipo()
        {
            InitializeComponent();
        }
        private void ctrlEquipo_Load(object sender, EventArgs e)
        {
            lEquipos = sEquipo.buscarTodos();
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            grdEquipos.Rows.Clear();
            if (lEquipos != null)
                foreach (Equipo equipo in lEquipos)
                {
                    grdEquipos.Rows.Add(equipo.Id, equipo.Nombre, equipo.Localidad);
                }
            grdEquipos.ClearSelection();
        }

        private void toggleEdit(bool edit)
        {
            btnAceptar.Enabled = edit;
            btnCancelar.Enabled = edit;
            btnAgregar.Enabled = !edit;
            btnLimpiar.Enabled = !edit;

            txtNombre.Enabled = !edit;
            txtLocalidad.Enabled = !edit;

            txtDetNombre.Enabled = edit;
            txtDetLocalidad.Enabled = edit;
            txtDetEntrenador.Enabled = edit;

            grdEquipos.Enabled = !edit;

            if (grdEquipos.SelectedRows.Count == 0)
            {
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            else
            {
                btnEditar.Enabled = !edit;
                btnEliminar.Enabled = !edit;
            }
        }


        private void grdEquipos_SelectionChanged(object sender, EventArgs e)
        {
            if (grdEquipos.SelectedRows.Count == 0)
                limpiarCampos();
            else
                cargarCampos();
        }

        private void cargarCampos()
        {
            Equipo equipo = equipoActual();

            txtDetNombre.Text = equipo.Nombre;
            txtDetLocalidad.Text = equipo.Localidad;
            txtDetEntrenador.Text = equipo.Entrenador;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void limpiarCampos()
        {
            txtDetNombre.Text = "";
            txtDetLocalidad.Text = "";
            txtDetEntrenador.Text = "";
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private Equipo equipoActual()
        {
            foreach (Equipo equipo in lEquipos)
                if (equipo.Id == (int)grdEquipos.SelectedRows[0].Cells[0].Value)
                    return equipo;
            return null;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void txtLocalidad_TextChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void filtrar()
        {
            lEquipos = sEquipo.filtrar(txtNombre.Text, txtLocalidad.Text);
            cargarGrilla();    
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtLocalidad.Text = "";

            lEquipos = sEquipo.buscarTodos();
            cargarGrilla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            nuevo = true;
            grdEquipos.ClearSelection();
            toggleEdit(true);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            toggleEdit(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Equipo actual = equipoActual();
            DialogResult answer = MessageBox.Show(
                "¿Desea eliminar el equipo " + actual.Nombre + "?",
                "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (answer == DialogResult.Yes)
            {
                if (sEquipo.eliminar(actual))
                {
                    filtrar();
                    MessageBox.Show("Equipo eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Error al eliminar equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                Equipo equipo = nuevo ? new Equipo() : equipoActual();
                equipo.Nombre = txtDetNombre.Text;
                equipo.Localidad = txtDetLocalidad.Text;
                equipo.Entrenador = txtDetEntrenador.Text;

                if (nuevo)
                {
                    equipo.Borrado = 0;

                    if (sEquipo.grabar(equipo))
                    {
                        filtrar();
                        MessageBox.Show("Equipo grabado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Error al grabar Equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nuevo = false;
                }
                else
                {
                    if (sEquipo.actualizar(equipo))
                    {
                        filtrar();
                        MessageBox.Show("Equipo actualizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Error al actualizar equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            grdEquipos.ClearSelection();
        }

        private bool validarCampos()
        {
            if (txtDetNombre.Text == "") return false;
            if (txtDetLocalidad.Text == "") return false;
            if (txtDetEntrenador.Text == "") return false;
            return true;
        }

    }
}
