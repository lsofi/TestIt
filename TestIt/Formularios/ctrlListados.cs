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
using TestIt.Estadisticas;

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


        private void btnDeportista_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleListados(new ctrlListadoDeporistas(fPrincipal));
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleListados(new ctrlListadoEquipos(fPrincipal));
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleListados(new ctrlListadoUsuarios(fPrincipal));
        }

        private void btnTests_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleListados(new ctrlListadoTests(fPrincipal));
        }

        
	    private void btnCategorias_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleListados(new ctrlListadoCategorias(fPrincipal));

        }

        private void btnRendDeportista_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleListados(new ctrlEstEvolucionDeportista(fPrincipal));
        }

        private void btnCompEquipos_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleListados(new ctrlEstComparacionEquipos(fPrincipal));
        }

        private void btnTestRealizados_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleListados(new ctrlEstProporcionTests(fPrincipal));
        }

        private void btnTestsxEquipo_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleListados(new ctrlEstRendimientoDeportista(fPrincipal));
        }

        private void btnTestsxEsSubjetivo_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleListados(new ctrlEstEsfuerzoPorTest(fPrincipal));
        }
    }
}
