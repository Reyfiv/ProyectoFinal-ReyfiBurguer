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
    public partial class rProductos : Form
    {
        public rProductos()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            ProductoIdNumericUpDown.Value = 0;
            NombreProductoTextBox.Text = string.Empty;
            TipoProductoComboBox.Text = string.Empty;
            PrecioNumericUpDown.Value = 0;
            DescripcionComboBox.Text = string.Empty;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private Productos LlenaClase()
        {
            Productos producto = new Productos();
            producto.ProductoId = Convert.ToInt32(ProductoIdNumericUpDown.Value);
            producto.NombreProducto = NombreProductoTextBox.Text;
            producto.TipoProducto = TipoProductoComboBox.Text;
            producto.Precio = Convert.ToDecimal(PrecioNumericUpDown.Value);
            producto.Descripcion = DescripcionComboBox.Text;
            return producto;
        }

        public bool Validar()
        {
            bool validar = false;
            if (String.IsNullOrEmpty(NombreProductoTextBox.Text))
            {
                errorProvider1.SetError(NombreProductoTextBox, "El campo *Nombre del producto* esta vacio");
                validar = true;
            }
            if (String.IsNullOrWhiteSpace(NombreProductoTextBox.Text))
            {
                errorProvider1.SetError(NombreProductoTextBox, "El campo *Nombre del producto* esta vacio");
                validar = true;
            }
            if (String.IsNullOrEmpty(TipoProductoComboBox.Text))
            {
                errorProvider1.SetError(TipoProductoComboBox, "Seleccione un  *Tipo de producto*");
                validar = true;
            }
            if(PrecioNumericUpDown.Value == 0)
            {
                errorProvider1.SetError(PrecioNumericUpDown, "Digite un *Precio* mayor que cero (0.00)");
                validar = true;
            }
            if (String.IsNullOrEmpty(DescripcionComboBox.Text))
            {
                errorProvider1.SetError(DescripcionComboBox, "Seleccione una  *Descripcion*");
                validar = true;
            }
            return validar;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Productos productos = ProductosBLL.Buscar((int)ProductoIdNumericUpDown.Value);
            return (productos != null);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Productos producto;
            bool paso = false;
            if (Validar())
            {
                MessageBox.Show("Favor revisar todos los campos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            producto = LlenaClase();

            if (ProductoIdNumericUpDown.Value == 0)
                paso = ProductosBLL.Guardar(producto);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("El Usuario no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = ProductosBLL.Modificar(producto);
            }
            Limpiar();

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ProductoIdNumericUpDown.Value);
            if (ProductosBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo eliminar", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ProductoIdNumericUpDown.Value);
            Productos producto = ProductosBLL.Buscar(id);

            if (producto != null)
            {

                NombreProductoTextBox.Text = producto.NombreProducto;
                TipoProductoComboBox.Text = producto.TipoProducto;
                PrecioNumericUpDown.Value = producto.Precio;
                DescripcionComboBox.Text = producto.Descripcion;
            }
            else
                MessageBox.Show("No existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
