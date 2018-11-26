using ReyfiBurguer.BLL;
using ReyfiBurguer.DAL;
using ReyfiBurguer.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ReyfiBurguer.UI.Registros
{
    public partial class rCombos : Form
    {
        public List<ProductosDetalle> Detalle { get; set; }
       

        public rCombos()
        {
            InitializeComponent();
            this.Detalle = new List<ProductosDetalle>();
            LlenaCombo();
        }


        private void CargarGrid()
        {
            ComboDataGridView.DataSource = null;
            ComboDataGridView.DataSource = this.Detalle;
        }

        private void Limpiar()
        {
            errorProvider1.Clear();

            ComboIdNumericUpDown.Value = 0;
            NombreComboTextBox.Text = string.Empty;
            PrecioTotalComboTextBox.Text = string.Empty;

            this.Detalle = new List<ProductosDetalle>();
            CargarGrid();
        }

        private Combos LlenaClase()
        {
            Combos combo = new Combos();
            combo.ComboId = Convert.ToInt32(ComboIdNumericUpDown.Value);
            combo.NombreCombo = NombreComboTextBox.Text;
            combo.PrecioTotalCombo = Convert.ToDecimal(PrecioTotalComboTextBox.Text);

            combo.Producto = this.Detalle;

            return combo;
        }

        private void LlenaCampos(Combos combos)
        {
            ComboIdNumericUpDown.Value = combos.ComboId;
            NombreComboTextBox.Text = combos.NombreCombo;
            PrecioTotalComboTextBox.Text = Convert.ToString(combos.PrecioTotalCombo);

            this.Detalle = combos.Producto;
            CargarGrid();
        }

        public bool Validar()
        {
            bool validar = false;
            if (String.IsNullOrEmpty(NombreComboTextBox.Text))
            {
                errorProvider1.SetError(NombreComboTextBox, "El campo *Nombre del combo* esta vacio");
                validar = true;
            }
            if (String.IsNullOrWhiteSpace(NombreComboTextBox.Text))
            {
                errorProvider1.SetError(NombreComboTextBox, "El campo *Nombre del combo* esta vacio");
                validar = true;
            }
            if (NombreComboTextBox.Text == "." || NombreComboTextBox.Text == ";" || NombreComboTextBox.Text == "/" || NombreComboTextBox.Text == " * " || NombreComboTextBox.Text == "-" || NombreComboTextBox.Text == "+" || NombreComboTextBox.Text == ":" || NombreComboTextBox.Text == "@" || NombreComboTextBox.Text == "#" || NombreComboTextBox.Text == "!" || NombreComboTextBox.Text == "{" || NombreComboTextBox.Text == "}")
            {
                errorProvider1.SetError(NombreComboTextBox, "Escriba un *Nombre del combo* valido");
                validar = true;
            }

            if (ComboDataGridView.RowCount == 0)
            {
                errorProvider1.SetError(ComboDataGridView, "Debe agregar algun *Producto* al combo antes de guardar");
                validar = true;
            }
            return validar;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Combos combo = CombosBLL.Buscar((int)ComboIdNumericUpDown.Value);
            return (combo != null);
        }

        public void LlenaCombo()
        {

            List<Productos> lista = ProductosBLL.GetList(x => true);
            ProductoComboBox.DataSource = lista;
            ProductoComboBox.ValueMember = "ProductoId";
            ProductoComboBox.DisplayMember = "NombreProducto";
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Combos combo;
            bool paso = false;
            if (Validar())
            {
                MessageBox.Show("Favor revisar todos los campos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            combo = LlenaClase();

            if (ComboIdNumericUpDown.Value == 0)
                paso = CombosBLL.Guardar(combo);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("El Vendedor no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = CombosBLL.Modificar(combo);
            }
            Limpiar();

            if (paso)
                MessageBox.Show("Guardado", "Con Exito!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo Guardar", "Error!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ComboIdNumericUpDown.Value);
            if (CombosBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo eliminar", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ComboIdNumericUpDown.Value);
            Combos combo  = BLL.CombosBLL.Buscar(id);
            if (combo != null)
            {
                NombreComboTextBox.Text = combo.NombreCombo;
                PrecioTotalComboTextBox.Text = Convert.ToString(combo.PrecioTotalCombo);
                ComboDataGridView.DataSource = combo.Producto;
            }
            else
                MessageBox.Show("No existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (ComboDataGridView.DataSource != null)
                this.Detalle = (List<ProductosDetalle>)ComboDataGridView.DataSource;

            
            var producto = ProductosBLL.Buscar((int)ProductoComboBox.SelectedValue);
            
            this.Detalle.Add(new ProductosDetalle(0, producto.ProductoId,producto.NombreProducto, producto.TipoProducto, producto.Precio, producto.Descripcion));
            CargarGrid();

            decimal calculo = 0;
            Decimal.TryParse(PrecioTotalComboTextBox.Text, out calculo);
            calculo = calculo + producto.Precio;
            PrecioTotalComboTextBox.Text = calculo.ToString();
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if (ComboDataGridView.Rows.Count > 0 && ComboDataGridView.CurrentRow != null)
            {
                this.Detalle = (List<ProductosDetalle>)ComboDataGridView.DataSource;
                Detalle.RemoveAt(ComboDataGridView.CurrentRow.Index);
                CargarGrid();

                // Rebajar totales
                List<ProductosDetalle> detalle = new List<ProductosDetalle>();

                if (ComboDataGridView.DataSource != null)
                {
                    detalle = (List<ProductosDetalle>)ComboDataGridView.DataSource;
                }
                decimal Total = 0;
                foreach (var item in detalle)
                {
                    Total -= item.Precio;
                }
                Total *= (-1);
                PrecioTotalComboTextBox.Text = Total.ToString();
            }
        }

    }
}

