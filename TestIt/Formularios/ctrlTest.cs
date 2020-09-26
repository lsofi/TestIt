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
    public partial class ctrlTest : UserControl
    {
        private frmPrincipal fPrincipal;

        private List<Test> lTests;
        private List<Medicion> lMediciones;
        private bool nuevo = false;

        public ctrlTest(frmPrincipal fp)
        {
            InitializeComponent();
            fPrincipal = fp;
        }

        private void ctrlTest_Load(object sender, EventArgs e)
        {
            lTests = Test.buscarTests();
            cargarGrilla();
            lMediciones = Medicion.buscarMediciones();
            cargarMediciones();
        }

        private void cargarGrilla()
        {
            grdTest.Rows.Clear();
            if (lTests != null)
                foreach (Test test in lTests)
                {
                    grdTest.Rows.Add(test.Id, test.Nombre);
                }
            grdTest.ClearSelection();
        }

        private void cargarMediciones()
        {
            grdMediciones.Rows.Clear();
            if (lMediciones != null)
                foreach (Medicion medicion in lMediciones)
                {
                    grdMediciones.Rows.Add(medicion.Id, false, medicion.Nombre);
                }
            grdMediciones.ClearSelection();
        }

        private void grdTest_SelectionChanged(object sender, EventArgs e)
        {
            if (grdTest.SelectedRows.Count == 0)
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
            txtDescripcion.Enabled = edit;
            grdMediciones.Enabled = edit;
            grdMediciones.ClearSelection();
            txtBuscarMediciones.Enabled = edit;

            grdTest.Enabled = !edit;
        }

        private void cargarCampos()
        {
            Test test = testActual();
            if (test == null) return;
            txtDetNombre.Text = test.Nombre;
            txtDescripcion.Text = test.Descripcion;
            foreach (DataGridViewRow row in grdMediciones.Rows)
            {
                if (test.IdMediciones.Contains((int)row.Cells[0].Value))
                    row.Cells[1].Value = true;
                else
                    row.Cells[1].Value = false;
            }

            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void limpiarCampos()
        {
            txtDetNombre.Text = "";
            txtDescripcion.Text = "";
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

            foreach (DataGridViewRow row in grdMediciones.Rows) 
                row.Cells[1].Value = false;
        }

        private Test testActual()
        {
            foreach (Test test in lTests)
                if (test.Id == (int)grdTest.SelectedRows[0].Cells[0].Value)
                    return test;
            return null;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void filtrar()
        {
            lTests = Test.filtrarTests(txtNombre.Text);
            cargarGrilla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            nuevo = true;
            grdTest.ClearSelection();
            toggleEdit(true);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            toggleEdit(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Test actual = testActual();
            DialogResult answer = MessageBox.Show(
                "¿Desea eliminar el test " + actual.Nombre + "?",
                "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (answer == DialogResult.Yes)
            {
                if (actual.eliminar())
                {
                    filtrar();
                    MessageBox.Show("Test eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Error al eliminar test", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                Test test = nuevo ? new Test() : testActual();
                test.Nombre = txtDetNombre.Text;
                test.Descripcion = txtDescripcion.Text == null ? " " : txtDescripcion.Text;

                foreach (DataGridViewRow row in grdMediciones.Rows)
                {
                    if ((bool)row.Cells[1].Value)
                        test.addMedicion((int)row.Cells[0].Value);
                    else
                        test.removeMedicion((int)row.Cells[0].Value);
                }


                if (nuevo)
                {
                    test.Borrado = 0;

                    if (test.grabar())
                    {
                        filtrar();
                        MessageBox.Show("Test grabado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Error al grabar test", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nuevo = false;
                }
                else
                {
                    if (test.actualizar())
                    {
                        filtrar();
                        MessageBox.Show("Test actualizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Error al actualizar test", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                toggleEdit(false);
            }
            else
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarCampos();
        }

        private bool validarCampos()
        {
            if (txtDetNombre.Text == "") return false;
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            toggleEdit(false);
            limpiarCampos();
            grdTest.ClearSelection();
        }

        private void txtBuscarMediciones_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarMediciones.Text != "Buscar mediciones..." && txtBuscarMediciones.Text != "")
            {
                lMediciones = Medicion.filtrarMediciones(txtBuscarMediciones.Text);
                cargarMediciones();
            }
            else
            {
                lMediciones = Medicion.buscarMediciones();
                cargarMediciones();
            }
        }

        private void txtBuscarMediciones_Click(object sender, EventArgs e)
        {
            if (txtBuscarMediciones.Text == "Buscar mediciones...")
                txtBuscarMediciones.Text = "";
        }

        private void txtBuscarMediciones_Leave(object sender, EventArgs e)
        {
            if (txtBuscarMediciones.Text == "")
                txtBuscarMediciones.Text = "Buscar mediciones...";
        }

        private void btnModificarMediciones_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleMediciones();
        }

        private void grdMediciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check to ensure that the row CheckBox is clicked.
            if (e.RowIndex >= 0)
            {
                //Reference the GridView Row.
                DataGridViewRow row = grdMediciones.Rows[e.RowIndex];

                //Set the CheckBox selection.
                row.Cells[1].Value = !Convert.ToBoolean(row.Cells[1].EditedFormattedValue);
            }
        }
    }
}
