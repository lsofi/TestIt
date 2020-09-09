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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            frmLogin login = new frmLogin();
            //login.ShowDialog();
            this.lblBienvenido.Text = "Bienvenido " + login.UsuarioLogueado;

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
        
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnDeportistas_Click(object sender, EventArgs e)
        {
            ctrlDeportistas ctrlDeportistas = new ctrlDeportistas();
            panelContenedor.Controls.Add(ctrlDeportistas);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
