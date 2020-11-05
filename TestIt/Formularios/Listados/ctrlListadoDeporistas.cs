using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestIt.Datos;
using TestIt.Formularios;
using TestIt.Soporte;
using Microsoft.Reporting.WinForms;

namespace TestIt.Formularios.Listados
{
    public partial class ctrlListadoDeporistas : UserControl
    {
        ListadosDao lDao = new ListadosDao();
        frmPrincipal fPrincipal;

        public ctrlListadoDeporistas(frmPrincipal fp)
        {
            InitializeComponent();
            fPrincipal = fp;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleListados(null);
        }



        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            {
                rpvDeportistas.LocalReport.SetParameters(new ReportParameter[]{
                new ReportParameter("usuario", Globals.UsuarioActual.NombreUsuario),
                new ReportParameter("prFechaDesde", dtpDesde.Value.ToString("dd/MM/yyyy")),
                new ReportParameter("prFechaHasta", dtpHasta.Value.ToString("dd/MM/yyyy")) });

                //DATASOURCE
                
                rpvDeportistas.LocalReport.DataSources.Add(new ReportDataSource("DataSetListados", listadoDeportistas(dtpDesde.Value, dtpHasta.Value)));
                rpvDeportistas.RefreshReport();
            }
        }

       

        public DataTable listadoDeportistas(DateTime desde, DateTime hasta)
        {
            DataManager dm = DataManager.GetInstance();
            string consulta = "SELECT d.nombre, d.apellido, e.nombre as equipo, c.nombre as categoria, count(*) as cant_ejecuciones" +
                " FROM deportistas d " +
                " JOIN equipos e on d.id_equipo = e.id" +
                " JOIN categorias c on d.id_categoria = c.id" +
                " JOIN ejecuciones ej on d.id = ej.id_deportista" +
                " WHERE d.borrado = 0 AND ej.fecha BETWEEN '" + desde.ToString("yyyy-MM-dd") + "' AND '" + hasta.ToString("yyyy-MM-dd") + "'" +
                " GROUP BY d.nombre, d.apellido, e.nombre, c.nombre";


            return dm.ConsultaSQL(consulta);

        }
    }
}
