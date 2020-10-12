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
            fPrincipal.toggleListados(new ctrlListadoEjecuciones());
        }
    }
}
