using ReyfiBurguer.BLL;
using ReyfiBurguer.Entidades;
using ReyfiBurguer.UI.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReyfiBurguer.UI.Consultas
{
    public partial class cVentas : Form
    {
       private List<Ventas> Listaventas = new List<Ventas>();

        public cVentas()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Expression<Func<Ventas, bool>> filtro = a => true;
           
                switch (FiltrarComboBox.SelectedIndex)
                {
                    case 0://Fecha
                        filtro = a => a.Fecha >= FechaDesdeDateTimePicker.Value.Date && a.Fecha <= FechaHastaDateTimePicker.Value.Date; 
                        break;
                    case 1://Total
                    filtro = a => a.TotalAPagar.Equals(CriterioTextBox.Text);
                    break;
                }

            Listaventas = VentasBLL.GetList(filtro);
            ConsultaDataGridView.DataSource = Listaventas;
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            if(Listaventas.Count == 0)
            {
                MessageBox.Show("No hay datos para Imprimir");
                return;
            }

            VentasReportViewer reporteVentas = new VentasReportViewer(Listaventas);
            reporteVentas.ShowDialog();
        }
    }
}
