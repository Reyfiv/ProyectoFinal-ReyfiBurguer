using ReyfiBurguer.BLL;
using ReyfiBurguer.Entidades;
using ReyfiBurguer.UI;
using ReyfiBurguer.UI.Registros;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace ReyfiBurguer
{
    public partial class InisioSesion : Form
    {
        public InisioSesion()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            UsuarioTextBox.Clear();
            ContraseñaTextBox.Clear();
        }

        private bool Validar()
        {
            bool validar = false;
            if (String.IsNullOrWhiteSpace(UsuarioTextBox.Text))
            {
                errorProvider1.SetError(UsuarioTextBox, "Usuario Vacio");
                validar = true;

            }
            if (String.IsNullOrWhiteSpace(ContraseñaTextBox.Text))
            {
                errorProvider1.SetError(ContraseñaTextBox, "Usuario Vacio");
                validar = true;
            }
            return validar;
        }

        private void IniciarButton_Click(object sender, EventArgs e)
        {
            Expression<Func<Usuarios, bool>> filtrar = x => true;
            List<Usuarios> usuario = new List<Usuarios>();

            if (Validar())
            {
                MessageBox.Show("Favor revisar todos los campos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            filtrar = t => t.NombreUsuario.Equals(UsuarioTextBox.Text);
            usuario = UsuariosBLL.GetList(filtrar);

            if (usuario.Exists(x => x.NombreUsuario == UsuarioTextBox.Text) && usuario.Exists(x => x.Contraseña == ContraseñaTextBox.Text) && usuario.Exists(x => x.TipoUsuario == x.TipoUsuario))
            {
                foreach (var item in UsuariosBLL.GetList(x => x.NombreUsuario == UsuarioTextBox.Text))
                {
                    UsuariosBLL.IniciarSecion(item.NombreUsuario, item.Contraseña, item.TipoUsuario);

                    if (item.TipoUsuario == "Administrador")
                    {
                        MessageBox.Show("*Bienvenido usuario administrador*");
                        MenuPrincipalAdmin abrir = new MenuPrincipalAdmin();
                        abrir.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("*Bienvenido usuario cajero*");
                        rVentas abrir = new rVentas();
                        abrir.Show();
                        this.Hide();
                    }
                }
            }
            else
                MessageBox.Show("Nombre de usuario o contraseña incorrecta!!");
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InisioSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
