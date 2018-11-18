using ReyfiBurguer.BLL;
using ReyfiBurguer.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReyfiBurguer.UI.Registros
{
    public partial class rUsuarios : Form
    {
        public rUsuarios()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            UsuarioIdNumericUpDown.Value = 0;
            NombresTextBox.Text = string.Empty;
            NombreUsuarioTextBox.Text = string.Empty;
            ContraseñaTextBox.Text = string.Empty;
            ConfirmarContraseñaTextBox.Text = string.Empty;
            TipoUsuarioComboBox.Text = string.Empty;
            
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private Usuarios LlenaClase()
        {
            Usuarios usuario = new Usuarios();
            usuario.UsuarioId = Convert.ToInt32(UsuarioIdNumericUpDown.Value);
            usuario.Nombres = NombresTextBox.Text;
            usuario.NombreUsuario = NombreUsuarioTextBox.Text;
            usuario.Contraseña = ContraseñaTextBox.Text;
            usuario.ConfirmarContraseña = ConfirmarContraseñaTextBox.Text;
            usuario.TipoUsuario = TipoUsuarioComboBox.Text;
            return usuario;
        }

        public bool Validar()
        {
            bool validar = false;
            if (String.IsNullOrEmpty(NombresTextBox.Text))
            {
                errorProvider1.SetError(NombresTextBox, "El campo *Nombres* esta vacio");
                validar = true;
            }
            if(String.IsNullOrWhiteSpace(NombresTextBox.Text))
            {
                errorProvider1.SetError(NombresTextBox, "El campo *Nombres* esta vacio");
                validar = true;
            }
            if (String.IsNullOrEmpty(NombreUsuarioTextBox.Text))
            {
                errorProvider1.SetError(NombreUsuarioTextBox, "El campo *Nombre de usuario* esta vacio");
                validar = true;
            }
            if (String.IsNullOrWhiteSpace(NombreUsuarioTextBox.Text))
            {
                errorProvider1.SetError(NombreUsuarioTextBox, "El campo *Nombre de usuario* esta vacio");
                validar = true;
            }
            if (String.IsNullOrEmpty(ContraseñaTextBox.Text))
            {
                errorProvider1.SetError(ContraseñaTextBox, "El campo *Contraseña* esta vacio");
                validar = true;

            }
            if (String.IsNullOrWhiteSpace(ContraseñaTextBox.Text))
            {
                errorProvider1.SetError(ContraseñaTextBox, "El campo *Contraseña* esta vacio");
                validar = true;
            }
            if (String.IsNullOrEmpty(ConfirmarContraseñaTextBox.Text))
            {
                errorProvider1.SetError(ConfirmarContraseñaTextBox, "El campo *Contraseña* esta vacio");
                validar = true;

            }
            if (String.IsNullOrWhiteSpace(ConfirmarContraseñaTextBox.Text))
            {
                errorProvider1.SetError(ConfirmarContraseñaTextBox, "El campo *Contraseña* esta vacio");
                validar = true;
            }
            if (String.IsNullOrEmpty(TipoUsuarioComboBox.Text))
            {
                errorProvider1.SetError(TipoUsuarioComboBox, "No a seleccionado en el campo *Tipo de usuario*");
                validar = true;
            }
            if(ContraseñaTextBox.Text != ConfirmarContraseñaTextBox.Text)
            {
                errorProvider1.SetError(ContraseñaTextBox, "Revise las contraseñas, no son identicas");
                validar = true;
            }
            if (ConfirmarContraseñaTextBox.Text != ContraseñaTextBox.Text)
            {
                errorProvider1.SetError(ConfirmarContraseñaTextBox, "Revise las contraseñas, no son identicas");
                validar = true;
            }
            return validar;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Usuarios usuario = UsuariosBLL.Buscar((int)UsuarioIdNumericUpDown.Value);
            return (usuario != null);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Usuarios  usuario;
            bool paso = false;
            if (Validar())
            {
                MessageBox.Show("Favor revisar todos los campos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            usuario = LlenaClase();
            
            if (UsuarioIdNumericUpDown.Value == 0)
                paso = UsuariosBLL.Guardar(usuario);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("El Usuario no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = UsuariosBLL.Modificar(usuario);
            }
            Limpiar();
            
            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(UsuarioIdNumericUpDown.Value);
            if (UsuariosBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo eliminar", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(UsuarioIdNumericUpDown.Value);
            Usuarios usuario = UsuariosBLL.Buscar(id);

            if (usuario != null)
            {

                NombresTextBox.Text = usuario.Nombres;
                NombreUsuarioTextBox.Text = usuario.NombreUsuario;
                ContraseñaTextBox.Text = usuario.Contraseña;
                ConfirmarContraseñaTextBox.Text = usuario.ConfirmarContraseña;
                TipoUsuarioComboBox.Text = usuario.TipoUsuario;
            }
            else
                MessageBox.Show("No existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
