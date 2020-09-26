using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestIt.Formularios
{
    public partial class frmAux : Form
    {
        public frmAux()
        {
            InitializeComponent();
        }

        private void frmAux_Load(object sender, EventArgs e)
        {
            ctrlMedicion ctrlm = new ctrlMedicion();
            panelContenedor.Controls.Add(ctrlm);
        }
    }
}
