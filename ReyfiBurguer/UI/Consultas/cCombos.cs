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
    public partial class cCombos : Form
    {
        public cCombos()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Expression<Func<Combos, bool>> Filtro = a => true;

            var listado = new List<Combos>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltrarComboBox.SelectedIndex)
                {
                    case 0://Todo
                        listado = CombosBLL.GetList(p => true);
                        break;
                    case 1://NombreCombo
                        listado = CombosBLL.GetList(p => p.NombreCombo.Contains(CriterioTextBox.Text));
                        break;
                    case 3: //PrecioTotalCombo
                        listado = CombosBLL.GetList(p => p.PrecioTotalCombo.Equals(CriterioTextBox.Text));
                        break;
                }

            }
            else
                listado = CombosBLL.GetList(p => true);

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }
    }
    
}
