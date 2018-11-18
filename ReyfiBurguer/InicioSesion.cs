using ReyfiBurguer.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            SqlConnection conectar = new SqlConnection(@"Data Source =.\sqlExpress; Initial Catalog = ReyfiBurgerDb;" + "Integrated Security = True;");
            conectar.Open();
            string cd = "Select NombreUsuario, Contraseña from Usuarios where NombreUsuario = '" + UsuarioTextBox.Text + "' and Contraseña='" + ContraseñaTextBox.Text + "'";
            SqlCommand command = new SqlCommand(cd, conectar);
            SqlDataReader sqlData = command.ExecuteReader();
            if (sqlData.Read())
            {
                if (sqlData["NombreUsuario"].ToString() == UsuarioTextBox.Text && sqlData["Contraseña"].ToString() == ContraseñaTextBox.Text)
                {
                    MessageBox.Show("Usuario Correcto");
                    MenuPrincipal menuPrincipal = new MenuPrincipal();
                    menuPrincipal.Show();
                    this.Hide();
                }
            }
            else
                MessageBox.Show("Usuario o Contrasena Incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            conectar.Close();

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
