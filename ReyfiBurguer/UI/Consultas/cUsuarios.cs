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
    public partial class cUsuarios : Form
    {
        public cUsuarios()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Expression<Func<Usuarios, bool>> Filtro = a => true;

            var listado = new List<Usuarios>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltrarComboBox.SelectedIndex)
                {
                    case 0://Todo
                        listado = UsuariosBLL.GetList(p => true);
                        break;
                    case 1://Nombres
                        listado = UsuariosBLL.GetList(p => p.Nombres.Contains(CriterioTextBox.Text));
                        break;
                    case 2: //NombreUsuario
                        listado = UsuariosBLL.GetList(p => p.NombreUsuario.Contains(CriterioTextBox.Text));
                        break;
                    case 3: //TipoUsuario
                        listado = UsuariosBLL.GetList(p => p.TipoUsuario.Contains(CriterioTextBox.Text));
                        break;
                }

            }
            else
                listado = UsuariosBLL.GetList(p => true);

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }
    }
}
