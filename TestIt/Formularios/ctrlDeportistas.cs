using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestIt.Formularios
{
    public partial class ctrlDeportistas : UserControl
    {
        public ctrlDeportistas()
        {
            InitializeComponent();
        }

        private void ctrlDeportistas_Load(object sender, EventArgs e)
        {

        }

        private void toggleState()
        {
            btnAceptar.Enabled = !btnAceptar.Enabled;
            btnCancelar.Enabled = !btnAceptar.Enabled;
            btnAgregar.Enabled = !btnAgregar.Enabled;
            btnEditar.Enabled = !btnEditar.Enabled;
            btnEliminar.Enabled = !btnEliminar.Enabled;

            txtDetNombre.Enabled = !txtDetNombre.Enabled;
            txtDetApellido.Enabled = !txtDetApellido.Enabled;
            cboDetSexo.Enabled = !cboDetSexo.Enabled;
            dtpDetNacimiento.Enabled = !dtpDetNacimiento.Enabled;
            txtDetDNI.Enabled = !txtDetDNI.Enabled;
            cboDetDeporte.Enabled = !cboDetDeporte.Enabled;
            txtDetAltura.Enabled = !txtDetAltura.Enabled;
            cboDetEquipo.Enabled = !cboDetEquipo.Enabled;
            txtDetPeso.Enabled = !txtDetPeso.Enabled;
            cboDetCategoria.Enabled = !cboDetCategoria.Enabled;

            grdDeportistas.Enabled = !grdDeportistas.Enabled;
        }

        private void grdDeportistas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
