using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestIt.Soporte;
using TestIt.Logica;
using TestIt.Listados;

namespace TestIt.Formularios
{
    public partial class frmPrincipal : Form
    {

        ctrlDeportistas ctrlDeportistas;
        ctrlEquipo ctrlEquipo;
        ctrlCategoria ctrlCategoria;
        ctrlDeporte ctrlDeporte;
        ctrlTest ctrlTest;
        ctrlMedicion ctrlMedicion;
        ctrlEjecucion ctrlEjecucion;
        ctrlListados ctrlListados;
        private bool mediciones = false;
        private bool detalleEjecuciones = false;


        public frmPrincipal()
        {
            InitializeComponent();


            frmLogin login = new frmLogin();
            //login.ShowDialog();
            if(login.UsuarioLogueado != null)
                this.lblBienvenido.Text = "Bienvenido " + login.UsuarioLogueado.NombreUsuario;
            Globals.UsuarioActual = login.UsuarioLogueado;            
            Globals.UsuarioActual = new Usuario();
            Globals.UsuarioActual.IdUsuario = 1;
            Globals.UsuarioActual.NombreUsuario = "sofia";
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            ctrlDeportistas = new ctrlDeportistas();
            ctrlEquipo = new ctrlEquipo();
            ctrlCategoria = new ctrlCategoria();
            ctrlDeporte = new ctrlDeporte();
            ctrlTest = new ctrlTest(this);
            ctrlMedicion = new ctrlMedicion(this);
            ctrlEjecucion = new ctrlEjecucion(this);
            ctrlListados = new ctrlListados(this);
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

        private void btnTests_Click(object sender, EventArgs e)
        {
            mediciones = false;
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(ctrlTest);
        }

        private void btnDeportes_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(ctrlDeporte);
        }

        public void toggleMediciones()
        {
            panelContenedor.Controls.Clear();
            if (mediciones)
            {
                panelContenedor.Controls.Add(ctrlTest);
                ctrlTest.actualizarMediciones();
                mediciones = false;
            }
            else
            {
                panelContenedor.Controls.Add(ctrlMedicion);
                mediciones = true;
            }
        }

        private void btnEjecuciones_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(ctrlEjecucion);
            detalleEjecuciones = false;
        }

        public void toggleEjecuciones(Ejecucion ejecucion)
        {
            panelContenedor.Controls.Clear();
            if (detalleEjecuciones)
            {
                panelContenedor.Controls.Add(ctrlEjecucion);
                ctrlEjecucion.cargarDatos();
                detalleEjecuciones = false;
            }
            else
            {
                ctrlDetalleEjecucion ctrlDetalleEjecucion = new ctrlDetalleEjecucion(this, ejecucion);
                panelContenedor.Controls.Add(ctrlDetalleEjecucion);
                detalleEjecuciones = true;
            }
        }

        public void toggleListados(UserControl ctrl)
        {
            panelContenedor.Controls.Clear();
            if (ctrl == null)
            {
                panelContenedor.Controls.Add(ctrlListados);
            }
            else
            {
                panelContenedor.Controls.Add(ctrl);
            }
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            toggleListados(null);
        }
    }
}
