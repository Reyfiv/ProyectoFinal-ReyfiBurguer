using ReyfiBurguer.Entidades;
using ReyfiBurguer.UI.Registros;
using System;

using System.Windows.Forms;

namespace ReyfiBurguer.UI
{
    public partial class MenuPrincipalAdmin : Form
    {
        public MenuPrincipalAdmin()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
             new rUsuarios().Show();
            
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new rProductos().Show();
        }

        private void combosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new rCombos().Show();

        }
    }
}
