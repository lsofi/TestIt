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
    public partial class ctrlDetalleEjecucion : UserControl
    {
        private frmPrincipal fPrincipal;
        private Ejecucion ejecucion;
        private bool nuevo = false;
        private bool comboOk;

        public ctrlDetalleEjecucion(frmPrincipal fp, Ejecucion ej)
        {
            InitializeComponent();
            fPrincipal = fp;
            ejecucion = ej;
        }

        private void ctrlDetalleEjecucion_Load(object sender, EventArgs e)
        {
            cargarCombos();
            if(ejecucion == null)
            {
                nuevo = true;
                ejecucion = new Ejecucion();
                habilitarCampos();

            }
            else
            {
                cargarCampos();
                cargarGrilla();
            }
            
        }

        private void habilitarCampos()
        {
            txtObservacion.Enabled = true;
            cboDeportista.Enabled = true;
            cboTest.Enabled = true;
            dtpFecha.Enabled = true;
            toggleEdit(true);
        }

        private void cboTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboOk)
            {
                cargarGrillaNueva();
            }
        }

        private void cargarCombos()
        {
            comboOk = false;
            Combo.cargarCombo(cboTest, "tests");
            cboTest.SelectedIndex = -1;
            Combo.cargarCombo(cboDeportista, "deportistas", 2);
            cboDeportista.SelectedIndex = -1;
            comboOk = true;
        }

        private void cargarGrilla()
        {
            grdMediciones.Rows.Clear();
            if (ejecucion.Mediciones.Count != 0)
                foreach (int key in ejecucion.Mediciones.Keys)
                {
                    grdMediciones.Rows.Add(key, Medicion.buscarNombre(key), ejecucion.Mediciones[key], Medicion.buscarUnidad(key));
                }
            grdMediciones.ClearSelection();
        }

        private void cargarGrillaNueva()
        {
            grdMediciones.Rows.Clear();
            List<int> idMediciones = Test.buscarTestPorId((int)cboTest.SelectedValue).IdMediciones;
            foreach(int id in idMediciones)
            {
                Medicion medicion = Medicion.buscarMedicionPorId(id);
                grdMediciones.Rows.Add(id, medicion.Nombre, "", medicion.Unidad);
            }

        }

        private void cargarCampos()
        {
            if (ejecucion == null) return;
            txtNumero.Text = ejecucion.Numero.ToString();    
            dtpFecha.Value = ejecucion.Fecha;
            txtObservacion.Text = ejecucion.Observacion;
            comboOk = false;
            cboTest.SelectedValue = ejecucion.IdTest;
            cboDeportista.SelectedValue = ejecucion.IdDeportista;
            comboOk = true;
        }

        private void limpiarCampos()
        {
            comboOk = false;
            cboTest.SelectedIndex = -1;
            txtNumero.Text = "";
            cboDeportista.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
            txtObservacion.Text = "";
            grdMediciones.Rows.Clear();
            comboOk = true;
        }

        private void toggleEdit(bool edit)
        {
            btnEditar.Enabled = !edit;
            btnAceptar.Enabled = edit;
            btnCancelar.Enabled = edit;
            grdMediciones.Enabled = edit;
            btnVolver.Enabled = !edit;

            if (!edit)
                grdMediciones.ClearSelection();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            toggleEdit(true);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (nuevo)
            {
                if (!validarCampos())
                {
                    MessageBox.Show("Campos incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    ejecucion.Observacion = txtObservacion.Text;
                    ejecucion.Fecha = dtpFecha.Value;
                    ejecucion.IdTest = (int)cboTest.SelectedValue;
                    ejecucion.IdDeportista = (int)cboDeportista.SelectedValue;

                    foreach (DataGridViewRow row in grdMediciones.Rows)
                    {
                        ejecucion.addMedicion((int)row.Cells[0].Value, row.Cells[2].Value.ToString());
                    }

                    if (ejecucion.grabar())
                    {
                        MessageBox.Show("Ejecución grabada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Error al grabar ejecución", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                foreach (DataGridViewRow row in grdMediciones.Rows)
                {
                    ejecucion.setMedicion((int)row.Cells[0].Value, row.Cells[2].Value.ToString());
                }
                
                if (ejecucion.actualizar())
                {
                    MessageBox.Show("Ejecución actualizada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Error al actualizar ejecución", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            toggleEdit(false);
        }

        private bool validarCampos()
        {
            if (cboTest.SelectedIndex == -1 || cboDeportista.SelectedIndex == -1) return false;
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (nuevo)
                limpiarCampos();
            cargarGrilla();

            toggleEdit(false);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleEjecuciones(null);
        }
    }
}
