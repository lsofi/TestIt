using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestIt.Entidades;
using TestIt.Formularios;
using TestIt.Logica;

namespace TestIt.Formularios
{
    public partial class frmLogin : Form
    {
        public string UsuarioLogueado { get; internal set; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // Quita la opción de ocultar contraseña
            txtPassword.PasswordChar = '\0';
        }

        // Campo usuario
        private void txtUser_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
            }
            lblErrorU.Text = "";
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
            }
        }

        // Campo contraseña
        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '*';
            }
            lblErrorP.Text = "";
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Contraseña";
                txtPassword.PasswordChar = '\0';
            }
        }

        // Ingresar
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (validarCamposVacios()) return;

            GestorUsuario gestorUsuario = new GestorUsuario();
            Usuario user = gestorUsuario.BuscarUsuario(txtUser.Text);

            if (validarUsuario(user)) 
            { 
                UsuarioLogueado = user.NombreUsuario;
                Close();
            }
        }

        private bool validarCamposVacios()
        {
            bool error = false;

            if (txtUser.Text == "Usuario")
            {
                lblErrorU.Text = "Debe ingresar un usuario";
                error = true;
            }

            if (txtPassword.Text == "Contraseña")
            {
                lblErrorP.Text = "Debe ingresar una contraseña";
                error = true;
            }

            return error;
        }

        private bool validarUsuario(Usuario user)
        {
            if (user == null)
            {
                lblErrorU.Text = "Usuario incorrecto";
                return false;
            }

            if (!user.ValidarContraseña(txtPassword.Text))
            {
                lblErrorP.Text = "Contraseña incorrecta";
                return false;
            }
            return true;
        }

        // Cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
