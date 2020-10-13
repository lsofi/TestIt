using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestIt.Listados;

namespace TestIt.Formularios
{
    public partial class ctrlListados : UserControl
    {
        private frmPrincipal fPrincipal;

        public ctrlListados(frmPrincipal fPrincipal)
        {
            InitializeComponent();
            this.fPrincipal = fPrincipal;
        }

        private void btnEjecuciones_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleListados(new ctrlListadoEjecuciones(fPrincipal));
        }

        private void btnEjecuEquipo_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleListados(new ctrlListadoEjecuTest(fPrincipal));
        }

        private void btnEjecuDeport_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleListados(new ctrlListadoEjecuDeportista(fPrincipal));
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleListados(new ctrlListadoUsuarios(fPrincipal));
        }

        private void btnTests_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleListados(new ctrlListadoTests(fPrincipal));
        }
    }
}
