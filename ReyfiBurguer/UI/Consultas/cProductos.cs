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
    public partial class cProductos : Form
    {
        public cProductos()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Expression<Func<Productos, bool>> Filtro = a => true;

            var listado = new List<Productos>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltrarComboBox.SelectedIndex)
                {
                    case 0://Todo
                        listado = ProductosBLL.GetList(p => true);
                        break;
                    case 1://NombreProducto
                        listado = ProductosBLL.GetList(p => p.NombreProducto.Contains(CriterioTextBox.Text));
                        break;
                    case 2: //TipoProducto
                        listado = ProductosBLL.GetList(p => p.TipoProducto.Contains(CriterioTextBox.Text));
                        break;
                    case 3: //Precio
                        listado = ProductosBLL.GetList(p => p.Precio.Equals(CriterioTextBox.Text));
                        break;
                    case 4: //Descripcion
                        listado = ProductosBLL.GetList(p => p.Descripcion.Contains(CriterioTextBox.Text));
                        break;
                }

            }
            else
                listado = ProductosBLL.GetList(p => true);

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }
    }
    
}
