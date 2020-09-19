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
        private List<Deportista> lDeportistas;
        private bool comboOk = false;
        private bool nuevo = false;

        public ctrlEquipo()
        {
            InitializeComponent();
        }

        //private void ctrlDeportistas_Load(object sender, EventArgs e)
        //{
        //    lDeportistas = Deportista.buscarDeportistas();
        //    cargarGrilla();
        //    cargarCombos();
        //}

        //private void cargarGrilla()
        //{
        //    grdDeportistas.Rows.Clear();
        //    if (lDeportistas != null)
        //        foreach (Deportista dep in lDeportistas)
        //        {
        //            grdDeportistas.Rows.Add(dep.Id, dep.Nombre + " " + dep.Apellido);
        //        }
        //    grdDeportistas.ClearSelection();
        //}

        //private void cargarCombos()
        //{
        //    comboOk = false;
        //    Combo.cargarCombo(cboCategoria, "categorias");
        //    Combo.cargarCombo(cboDeporte, "deportes");
        //    Combo.cargarCombo(cboEquipo, "equipos");

        //    Combo.cargarCombo(cboDetCategoria, "categorias");
        //    Combo.cargarCombo(cboDetDeporte, "deportes");
        //    Combo.cargarCombo(cboDetEquipo, "equipos");
        //    cboDetSexo.DataSource = new List<string>() { "Masculino", "Femenino" };
        //    cboDetSexo.SelectedIndex = -1;
        //    comboOk = true;
        //}

        //private void toggleState()
        //{
        //    btnAceptar.Enabled = !btnAceptar.Enabled;
        //    btnCancelar.Enabled = !btnCancelar.Enabled;
        //    btnAgregar.Enabled = !btnAgregar.Enabled;
        //    btnEditar.Enabled = !btnEditar.Enabled;
        //    btnEliminar.Enabled = !btnEliminar.Enabled;
        //    btnLimpiar.Enabled = !btnLimpiar.Enabled;

        //    txtNombre.Enabled = !txtNombre.Enabled;
        //    cboCategoria.Enabled = !cboCategoria.Enabled;
        //    cboDeporte.Enabled = !cboDeporte.Enabled;
        //    cboEquipo.Enabled = !cboEquipo.Enabled;

        //    txtDetNombre.Enabled = !txtDetNombre.Enabled;
        //    txtDetApellido.Enabled = !txtDetApellido.Enabled;
        //    cboDetSexo.Enabled = !cboDetSexo.Enabled;
        //    dtpDetNacimiento.Enabled = !dtpDetNacimiento.Enabled;
        //    txtDetDNI.Enabled = !txtDetDNI.Enabled;
        //    cboDetDeporte.Enabled = !cboDetDeporte.Enabled;
        //    txtDetAltura.Enabled = !txtDetAltura.Enabled;
        //    cboDetEquipo.Enabled = !cboDetEquipo.Enabled;
        //    txtDetPeso.Enabled = !txtDetPeso.Enabled;
        //    cboDetCategoria.Enabled = !cboDetCategoria.Enabled;

        //    grdDeportistas.Enabled = !grdDeportistas.Enabled;
        //}

        //private void grdDeportistas_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (grdDeportistas.SelectedRows.Count == 0)
        //        limpiarCampos();
        //    else
        //        cargarCampos();
        //}

        //private void cargarCampos()
        //{
        //    Deportista dep = deportistaActual();
            
        //    txtDetApellido.Text = dep.Apellido;
        //    txtDetNombre.Text = dep.Nombre;
        //    txtDetDNI.Text = dep.Dni.ToString();
        //    txtDetPeso.Text = dep.Peso.ToString();
        //    txtDetAltura.Text = dep.Altura.ToString();
        //    cboDetCategoria.SelectedValue = dep.IdCategoria;
        //    cboDetDeporte.SelectedValue = dep.IdDeporte;
        //    cboDetEquipo.SelectedValue = dep.IdEquipo;
        //    dtpDetNacimiento.Value = dep.Nacimiento;
        //    if (comboOk)
        //        cboDetSexo.SelectedIndex = dep.Sexo;  
        //}

        //private void limpiarCampos()
        //{
        //    txtDetApellido.Text = "";
        //    txtDetNombre.Text = "";
        //    txtDetDNI.Text = "";
        //    txtDetPeso.Text = "";
        //    txtDetAltura.Text = "";
        //    cboDetCategoria.SelectedIndex = -1;
        //    cboDetDeporte.SelectedIndex = -1;
        //    cboDetEquipo.SelectedIndex = -1;
        //    cboDetSexo.SelectedIndex = -1;
        //    dtpDetNacimiento.Value = DateTime.Today;
            
        //}

        //private void txtNombre_TextChanged(object sender, EventArgs e)
        //{
        //    filtrar();
        //}

        //private void cboEquipo_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    filtrar();
        //}

        //private void cboDeporte_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    filtrar();
        //}

        //private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    filtrar();
        //}

        //private void filtrar()
        //{
        //    if (comboOk)
        //    {
        //        lDeportistas = Deportista.filtrarDeportistas(
        //            txtNombre.Text, 
        //            cboEquipo.SelectedIndex == -1 ? -1 :(int)cboEquipo.SelectedValue,
        //            cboDeporte.SelectedIndex == -1 ? -1 : (int)cboDeporte.SelectedValue,
        //            cboCategoria.SelectedIndex == -1 ? -1 : (int)cboCategoria.SelectedIndex);
        //        cargarGrilla();
        //    }
        //}

        //private void btnLimpiar_Click(object sender, EventArgs e)
        //{
        //    comboOk = false;
        //    txtNombre.Text = "";
        //    cboCategoria.SelectedIndex = -1;
        //    cboDeporte.SelectedIndex = -1;
        //    cboEquipo.SelectedIndex = -1;
        //    comboOk = true;

        //    lDeportistas = Deportista.buscarDeportistas();
        //    cargarGrilla();
        //}

        //private Deportista deportistaActual()
        //{
        //    foreach (Deportista dep in lDeportistas)
        //        if (dep.Id == (int)grdDeportistas.SelectedRows[0].Cells[0].Value)
        //            return dep;
        //    return null;
        //}

        //private void btnAgregar_Click(object sender, EventArgs e)
        //{
        //    nuevo = true;
        //    grdDeportistas.ClearSelection();
        //    toggleState(); 
        //}

        //private void btnEditar_Click(object sender, EventArgs e)
        //{
        //    toggleState();
        //}

        //private void btnEliminar_Click(object sender, EventArgs e)
        //{
        //    DialogResult answer = MessageBox.Show(
        //        "¿Desea eliminar al deportista " + grdDeportistas.SelectedRows[0].Cells[1].Value + "?",
        //        "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
        //    if (answer == DialogResult.Yes)
        //    {
        //        Deportista dep = deportistaActual();
        //        if (dep.eliminar())
        //        {
        //            filtrar();
        //            MessageBox.Show("Deportista eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //            MessageBox.Show("Error al eliminar deportista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void btnAceptar_Click(object sender, EventArgs e)
        //{
        //    if (validarCampos())
        //    {
        //        Deportista dep = nuevo ? new Deportista() : deportistaActual();
        //        dep.Apellido = txtDetApellido.Text;
        //        dep.Nombre = txtDetNombre.Text;
        //        dep.Peso = double.Parse(txtDetPeso.Text);
        //        dep.Altura = double.Parse(txtDetAltura.Text);
        //        dep.Dni = int.Parse(txtDetDNI.Text);
        //        dep.Nacimiento = dtpDetNacimiento.Value;
        //        dep.IdCategoria = (int)cboDetCategoria.SelectedValue;
        //        dep.IdDeporte = (int)cboDetDeporte.SelectedValue;
        //        dep.IdEquipo = (int)cboDetEquipo.SelectedValue;
        //        dep.Sexo = cboDetSexo.SelectedIndex;

        //        if (nuevo)
        //        {
        //            dep.Borrado = 0;

        //            if (dep.grabar())
        //            {
        //                lDeportistas = Deportista.buscarDeportistas();
        //                filtrar();
        //                MessageBox.Show("Deportista grabado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //            else
        //                MessageBox.Show("Error al grabar deportista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            nuevo = false;
        //        }
        //        else
        //        {
        //            if (dep.actualizar())
        //            {
        //                lDeportistas = Deportista.buscarDeportistas();
        //                filtrar();
        //                MessageBox.Show("Deportista actualizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //            else
        //                MessageBox.Show("Error al actualizar deportista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        toggleState();
        //    }
        //    else
        //        MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}

        //private void btnCancelar_Click(object sender, EventArgs e)
        //{
        //    toggleState();
        //    grdDeportistas.ClearSelection();
        //}

        //private bool validarCampos()
        //{
        //    if (txtDetNombre.Text == "") return false;
        //    if (txtDetApellido.Text == "") return false;
        //    if (txtDetPeso.Text == "") return false;
        //    if (txtDetAltura.Text == "") return false;
        //    if (txtDetDNI.Text == "") return false;
        //    if (cboDetDeporte.SelectedIndex == -1) return false;
        //    if (cboDetEquipo.SelectedIndex == -1) return false;
        //    if (cboDetSexo.SelectedIndex == -1) return false;
        //    if (cboDetCategoria.SelectedIndex == -1) return false;
        //    return true;
        //}

    }
}
