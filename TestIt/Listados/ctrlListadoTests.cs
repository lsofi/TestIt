using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestIt.Formularios;
using Microsoft.Reporting.WinForms;
using TestIt.Soporte;
using TestIt.Datos;
using TestIt.Logica;

namespace TestIt.Listados
{
    public partial class ctrlListadoTests : UserControl
    {
        ListadosDao lDao = new ListadosDao();
        frmPrincipal fPrincipal;

        public ctrlListadoTests(frmPrincipal fp)
        {
            InitializeComponent();
            fPrincipal = fp;
        }

 
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            rpvEjecuciones.LocalReport.SetParameters(new ReportParameter[]{
                new ReportParameter("usuario", Globals.UsuarioActual.NombreUsuario),
                new ReportParameter("prFechaDesde", dtpDesde.Value.ToString("dd/MM/yyyy")),
                new ReportParameter("prFechaHasta", dtpHasta.Value.ToString("dd/MM/yyyy")) });

            //DATASOURCE
            rpvEjecuciones.LocalReport.DataSources.Clear();
            rpvEjecuciones.LocalReport.DataSources.Add(new ReportDataSource("DataSetListados", listadoTests(dtpDesde.Value, dtpHasta.Value)));
            rpvEjecuciones.RefreshReport();

        }

        public DataTable listadoTests(DateTime desde, DateTime hasta)
        {
            DataManager dm = DataManager.GetInstance();
            String consulta =
                "SELECT t.nombre, t.descripcion, COUNT(*) AS 'cant_ejecuciones'" +
                "FROM ejecuciones e " +
                "JOIN tests t ON t.id = e.id_test " +
                "WHERE e.borrado = 0 " +
                "AND e.fecha BETWEEN '" + desde.ToString("yyyy-MM-dd") +
                "' AND '" + hasta.ToString("yyyy-MM-dd") + "'" +
                "GROUP BY t.nombre, t.descripcion";
               
            return dm.ConsultaSQL(consulta);
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleListados(null);
        }


    }
}
