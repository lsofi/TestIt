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
    public partial class ctrlDeportistas : UserControl
    {
        private DeportistaService sDeportista = new DeportistaService();
        private List<Deportista> lDeportistas;
        private bool comboOk = false;
        private bool nuevo = false;

        public ctrlDeportistas()
        {
            InitializeComponent();
        }

        private void ctrlDeportistas_Load(object sender, EventArgs e)
        {
            lDeportistas = sDeportista.buscarTodos();
            cargarGrilla();
            cargarCombos();
        }

        private void cargarGrilla()
        {
            grdDeportistas.Rows.Clear();
            if (lDeportistas != null)
                foreach (Deportista dep in lDeportistas)
                {
                    grdDeportistas.Rows.Add(dep.Id, dep.Nombre + " " + dep.Apellido);
                }
            grdDeportistas.ClearSelection();
        }

        private void cargarCombos()
        {
            comboOk = false;
            Combo.cargarCombo(cboCategoria, "categorias");
            Combo.cargarCombo(cboDeporte, "deportes");
            Combo.cargarCombo(cboEquipo, "equipos");

            Combo.cargarCombo(cboDetCategoria, "categorias");
            Combo.cargarCombo(cboDetDeporte, "deportes");
            Combo.cargarCombo(cboDetEquipo, "equipos");
            cboDetSexo.DataSource = new List<string>() { "Masculino", "Femenino" };
            cboDetSexo.SelectedIndex = -1;
            comboOk = true;
        }

        private void toggleState(bool state)
        {
            btnAceptar.Enabled = state;
            btnCancelar.Enabled = state;
            btnAgregar.Enabled = !state;
            btnLimpiar.Enabled = !state;

            txtApellido.Enabled = !state;
            cboCategoria.Enabled = !state;
            cboDeporte.Enabled = !state;
            cboEquipo.Enabled = !state;

            txtDetNombre.Enabled = state;
            txtDetApellido.Enabled = state;
            cboDetSexo.Enabled = state;
            dtpDetNacimiento.Enabled = state;
            txtDetDNI.Enabled = state;
            cboDetDeporte.Enabled = state;
            txtDetAltura.Enabled = state;
            cboDetEquipo.Enabled = state;
            txtDetPeso.Enabled = state;
            cboDetCategoria.Enabled = state;

            grdDeportistas.Enabled = !state;

            if(grdDeportistas.SelectedRows.Count == 0)
            {
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            else
            {
                btnEditar.Enabled = !state;
                btnEliminar.Enabled = !state;
            }
        }

        private void grdDeportistas_SelectionChanged(object sender, EventArgs e)
        {
            if (grdDeportistas.SelectedRows.Count == 0)
                limpiarCampos();
            else
                cargarCampos();
        }

        private void cargarCampos()
        {
            Deportista dep = deportistaActual();
            
            txtDetApellido.Text = dep.Apellido;
            txtDetNombre.Text = dep.Nombre;
            txtDetDNI.Text = dep.Dni.ToString();
            txtDetPeso.Text = dep.Peso.ToString();
            txtDetAltura.Text = dep.Altura.ToString();
            cboDetCategoria.SelectedValue = dep.IdCategoria;
            cboDetDeporte.SelectedValue = dep.IdDeporte;
            cboDetEquipo.SelectedValue = dep.IdEquipo;
            dtpDetNacimiento.Value = dep.Nacimiento;
            if (comboOk)
                cboDetSexo.SelectedIndex = dep.Sexo;

            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void limpiarCampos()
        {
            txtDetApellido.Text = "";
            txtDetNombre.Text = "";
            txtDetDNI.Text = "";
            txtDetPeso.Text = "";
            txtDetAltura.Text = "";
            cboDetCategoria.SelectedIndex = -1;
            cboDetDeporte.SelectedIndex = -1;
            cboDetEquipo.SelectedIndex = -1;
            cboDetSexo.SelectedIndex = -1;
            dtpDetNacimiento.Value = DateTime.Today;

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void cboEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void cboDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void filtrar()
        {
            if (comboOk)
            {
                lDeportistas = sDeportista.filtrar(
                    txtApellido.Text, 
                    cboEquipo.SelectedIndex == -1 ? -1 :(int)cboEquipo.SelectedValue,
                    cboDeporte.SelectedIndex == -1 ? -1 : (int)cboDeporte.SelectedValue,
                    cboCategoria.SelectedIndex == -1 ? -1 : (int)cboCategoria.SelectedIndex);
                cargarGrilla();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            comboOk = false;
            txtApellido.Text = "";
            cboCategoria.SelectedIndex = -1;
            cboDeporte.SelectedIndex = -1;
            cboEquipo.SelectedIndex = -1;
            comboOk = true;

            lDeportistas = sDeportista.buscarTodos();
            cargarGrilla();
        }

        private Deportista deportistaActual()
        {
            foreach (Deportista dep in lDeportistas)
                if (dep.Id == (int)grdDeportistas.SelectedRows[0].Cells[0].Value)
                    return dep;
            return null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            nuevo = true;
            toggleState(true);
            grdDeportistas.ClearSelection();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            toggleState(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                "¿Desea eliminar al deportista " + grdDeportistas.SelectedRows[0].Cells[1].Value + "?",
                "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (answer == DialogResult.Yes)
            {
                Deportista dep = deportistaActual();
                if (sDeportista.eliminar(dep))
                {
                    filtrar();
                    MessageBox.Show("Deportista eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Error al eliminar deportista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                Deportista dep = nuevo ? new Deportista() : deportistaActual();
                dep.Apellido = txtDetApellido.Text;
                dep.Nombre = txtDetNombre.Text;
                dep.Peso = double.Parse(txtDetPeso.Text);
                dep.Altura = double.Parse(txtDetAltura.Text);
                dep.Dni = int.Parse(txtDetDNI.Text);
                dep.Nacimiento = dtpDetNacimiento.Value;
                dep.IdCategoria = (int)cboDetCategoria.SelectedValue;
                dep.IdDeporte = (int)cboDetDeporte.SelectedValue;
                dep.IdEquipo = (int)cboDetEquipo.SelectedValue;
                dep.Sexo = cboDetSexo.SelectedIndex;

                if (nuevo)
                {
                    dep.Borrado = 0;

                    if (sDeportista.grabar(dep))
                    {
                        lDeportistas = sDeportista.buscarTodos();
                        filtrar();
                        MessageBox.Show("Deportista grabado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Error al grabar deportista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nuevo = false;
                }
                else
                {
                    if (sDeportista.actualizar(dep))
                    {
                        lDeportistas = sDeportista.buscarTodos();
                        filtrar();
                        MessageBox.Show("Deportista actualizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Error al actualizar deportista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                toggleState(false);
            }
            else
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            nuevo = false;
            toggleState(false);
            grdDeportistas.ClearSelection();
        }

        private bool validarCampos()
        {
            if (txtDetNombre.Text == "") return false;
            if (txtDetApellido.Text == "") return false;
            if (txtDetPeso.Text == "") return false;
            if (txtDetAltura.Text == "") return false;
            if (txtDetDNI.Text == "") return false;
            if (cboDetDeporte.SelectedIndex == -1) return false;
            if (cboDetEquipo.SelectedIndex == -1) return false;
            if (cboDetSexo.SelectedIndex == -1) return false;
            if (cboDetCategoria.SelectedIndex == -1) return false;
            return true;
        }
    }
}
