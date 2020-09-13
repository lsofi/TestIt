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
        }
    }
}
