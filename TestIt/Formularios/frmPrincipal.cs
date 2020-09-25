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

        ctrlDeportistas ctrlDeportistas;
        ctrlEquipo ctrlEquipo;
        ctrlCategoria ctrlCategoria;
        ctrlDeporte ctrlDeporte;
        ctrlTest ctrlTest;


        public frmPrincipal()
        {
            InitializeComponent();
           

            //frmLogin login = new frmLogin();
            //login.ShowDialog();
            //this.lblBienvenido.Text = "Bienvenido " + login.UsuarioLogueado;

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            ctrlDeportistas = new ctrlDeportistas();
            ctrlEquipo = new ctrlEquipo();
            ctrlCategoria = new ctrlCategoria();
            ctrlDeporte = new ctrlDeporte();
            ctrlTest = new ctrlTest();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnDeportistas_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(ctrlDeportistas);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(ctrlCategoria);
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(ctrlEquipo);
        }

        private void btnMediciones_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(ctrlTest);
        }

        private void btnDeportes_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(ctrlDeporte);
        }
    }
}
