
using ReyfiBurguer.Entidades;
using System.Collections.Generic;
using System.Windows.Forms;


namespace ReyfiBurguer.UI.Reportes
{

    public partial class VentasReportViewer : Form
    {
        private List<Ventas> ListaVentas;
        public VentasReportViewer(List<Ventas> Ventas)
        {
            
            InitializeComponent();
            this.ListaVentas = Ventas;
        }

        private void crystalReportViewer1_Load(object sender, System.EventArgs e)
        {
            ReporteVentas reporte = new ReporteVentas();
            reporte.SetDataSource(ListaVentas);
            crystalReportViewer1.ReportSource= reporte;
            reporte.Refresh();

        }
    }
}
