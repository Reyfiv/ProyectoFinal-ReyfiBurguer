using ReyfiBurguer.Entidades;
using ReyfiBurguer.UI.Consultas;
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

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new cProductos().Show();
        }

        private void comboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new cCombos().Show();
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new cUsuarios().Show();
        }

        //cierra aplicacion desde la ventana
        private void MenuPrincipalAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //cierra aplicacion desde item *cerrar sesion* 
        private void cerrarSecionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
