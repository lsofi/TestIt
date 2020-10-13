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
    public partial class ctrlListadoUsuarios : UserControl
    {
        ListadosDao lDao = new ListadosDao();
        frmPrincipal fPrincipal;

        public ctrlListadoUsuarios(frmPrincipal fp)
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
            rpvEjecuciones.LocalReport.DataSources.Add(new ReportDataSource("DataSetListados", listadoUsuarios(dtpDesde.Value, dtpHasta.Value)));
            rpvEjecuciones.RefreshReport();

        }
        public DataTable listadoUsuarios(DateTime desde, DateTime hasta)
        {
            DataManager dm = DataManager.GetInstance();
            String consulta =
                "SELECT u.nombre_usuario AS 'nombre', COUNT(*) AS 'cant_ejecuciones' " +
                "FROM ejecuciones e " +
                "JOIN usuarios u ON u.id = e.id_usuario" +
                " WHERE e.borrado = 0 " +
                " AND e.fecha BETWEEN '" + desde.ToString("yyyy-MM-dd") +
                "' AND '" + hasta.ToString("yyyy-MM-dd") + "'" +
                "GROUP BY u.nombre_usuario";
               
            return dm.ConsultaSQL(consulta);
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            fPrincipal.toggleListados(null);
        }


    }
}
