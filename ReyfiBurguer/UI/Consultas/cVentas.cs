using ReyfiBurguer.BLL;
using ReyfiBurguer.Entidades;
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

        public cVentas()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Expression<Func<Ventas, bool>> filtro = a => true;
            var listado = new List<Ventas>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltrarComboBox.SelectedIndex)
                {
                    case 0://Todo
                        listado = VentasBLL.GetList(p => true);
                        break;
                    case 1://Fecha
                        listado = VentasBLL.GetList(p => p.Fecha.Equals(CriterioTextBox.Text));
                        break;
                    case 3: //Total
                        listado = VentasBLL.GetList(p => p.TotalAPagar.Equals(CriterioTextBox.Text));
                        break;
                }

            }
            else
                listado = VentasBLL.GetList(p => true);

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }
    }
}
