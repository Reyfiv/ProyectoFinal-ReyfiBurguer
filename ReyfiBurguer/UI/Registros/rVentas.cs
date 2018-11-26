using ReyfiBurguer.BLL;
using ReyfiBurguer.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReyfiBurguer.UI.Registros
{
    public partial class rVentas : Form
    {
        List<ProductosDetalle> DetalleP = new List<ProductosDetalle>();
        List<CombosDetalle> DetalleC = new List<CombosDetalle>();

        public rVentas()
        {
            InitializeComponent();
            CargarLisViewProductos();
            CargarLisViewCombos();
        }

        private void CargarGridProductos()
        {
            VentasProductosDataGridView.DataSource = null;
            VentasProductosDataGridView.DataSource = this.DetalleP;
        }

        private void CargarGridCombos()
        {
            VentasComboDataGridView.DataSource = null;
            VentasComboDataGridView.DataSource = this.DetalleC;
        }

        private void Limpiar()
        {
            TotalTextBox.Text = string.Empty;
            EfectivoNumericUpDown.Value = 0;
            DevueltaTextBox.Text = string.Empty;

            this.DetalleP = new List<ProductosDetalle>();
            this.DetalleC = new List<CombosDetalle>();
            CargarGridProductos();
            CargarGridCombos();
        }

        private Ventas LlenaClase()
        {
            Ventas ventas = new Ventas();
            ventas.TotalAPagar = Convert.ToDecimal(TotalTextBox.Text);
            ventas.Efectivo = EfectivoNumericUpDown.Value;
            ventas.Devuelta = Convert.ToDecimal(DevueltaTextBox.Text);
            ventas.Fecha = FechaDateTimePicker.Value;

            ventas.DetalleProducto = this.DetalleP;
            ventas.DetalleCombo = this.DetalleC;

            return ventas;
        }

        private void LLenaCampos(Ventas ventas)
        {

            TotalTextBox.Text = Convert.ToString(ventas.TotalAPagar);
            EfectivoNumericUpDown.Value = ventas.Efectivo;
            DevueltaTextBox.Text = Convert.ToString(ventas.Devuelta);
            FechaDateTimePicker.Value = ventas.Fecha;

            this.DetalleP = ventas.DetalleProducto;
            this.DetalleC = ventas.DetalleCombo;
            CargarGridProductos();
            CargarGridCombos();
        }

        public bool Validar()
        {
            bool validar = false;
            if (EfectivoNumericUpDown.Value == 0)
            {
                errorProvider1.SetError(EfectivoNumericUpDown, "Debe agregar una cantidad mayor que (0.00) antes de pagar");
                validar = true;
            }
            return validar;
        }

        private void PagarButton_Click(object sender, EventArgs e)
        {
            Ventas ventas;
            bool paso = false;
            if (Validar())
            {
                MessageBox.Show("Favor revisar todos los campos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ventas = LlenaClase();
            paso = VentasBLL.Guardar(ventas);
            Limpiar();

            if (paso)
                MessageBox.Show("El pago fue realizado", "Exito!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Pago no realizado", "Error!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CargarLisViewProductos()
        {
            ImageList imagen = new ImageList();
            imagen.ImageSize = new Size(80, 80);
            // Cargar imagenes
            string[] dir = { };
            dir = Directory.GetFiles("C:/Users/Reyfi Vasquez/Documents/UCNE/Programacion Aplicada 1/Tareas Aplicada 1 C#/ReyfiBurguer/Fotos para Comida/Foto Productos ");
            try
            {
                foreach (string direc in dir)
                {
                    imagen.Images.Add(Image.FromFile(direc));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            List<Productos> prod = new List<Productos>();
            prod = ProductosBLL.GetList(x => true);
            foreach (Productos productos in prod)
            {
                ProductosListView.SmallImageList = imagen;
                ProductosListView.Items.Add(Convert.ToString(productos.ProductoId), productos.NombreProducto, 0);
            }
        }

        private void CargarLisViewCombos()
        {
            ImageList imagen = new ImageList();
            imagen.ImageSize = new Size(80, 80);
            // Cargar imagenes
            string[] dir = { };
            dir = Directory.GetFiles("C:/Users/Reyfi Vasquez/Documents/UCNE/Programacion Aplicada 1/Tareas Aplicada 1 C#/ReyfiBurguer/Fotos para Comida/Foto Combos ");
            try
            {
                foreach (string direc in dir)
                {
                    imagen.Images.Add(Image.FromFile(direc));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            List<Combos> comb = new List<Combos>();
            comb = CombosBLL.GetList(x => true);
            foreach (Combos combos in comb)
            {
                CombosListView.SmallImageList = imagen;
                CombosListView.Items.Add(Convert.ToString(combos.ComboId), combos.NombreCombo, 0);
            }
        }


        private void ProductosListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (VentasProductosDataGridView.DataSource != null)
                this.DetalleP = (List<ProductosDetalle>)VentasProductosDataGridView.DataSource;


                var lista = ProductosListView.SelectedItems;

                Productos productos = new Productos();
                productos.ProductoId = Convert.ToInt32(lista[0].Name);
                var producto = ProductosBLL.Buscar(productos.ProductoId);

                this.DetalleP.Add(new ProductosDetalle(0, producto.ProductoId, producto.NombreProducto, producto.TipoProducto, producto.Precio, producto.Descripcion));
                CargarGridProductos();

                decimal calculo = 0;
                Decimal.TryParse(TotalTextBox.Text, out calculo);
                calculo = calculo + producto.Precio;
                TotalTextBox.Text = calculo.ToString();
        }

        private void CombosListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (VentasComboDataGridView.DataSource != null)
                this.DetalleC = (List<CombosDetalle>)VentasComboDataGridView.DataSource;

                var lista = CombosListView.SelectedItems;

                Combos combos = new Combos();
                combos.ComboId = Convert.ToInt32(lista[0].Name);
                var combo = CombosBLL.Buscar(combos.ComboId);

                this.DetalleC.Add(new CombosDetalle(0, combo.ComboId, combo.NombreCombo, combo.PrecioTotalCombo));
                CargarGridCombos();

                decimal calculo = 0;
                Decimal.TryParse(TotalTextBox.Text, out calculo);
                calculo = calculo + combo.PrecioTotalCombo;
                TotalTextBox.Text = calculo.ToString();
            
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if (VentasProductosDataGridView.Rows.Count > 0 && VentasProductosDataGridView.CurrentRow != null)
            {
                this.DetalleP = (List<ProductosDetalle>)VentasProductosDataGridView.DataSource;
                DetalleP.RemoveAt(VentasProductosDataGridView.CurrentRow.Index);
                CargarGridProductos();

                // Rebajar totales
                List<ProductosDetalle> detalle = new List<ProductosDetalle>();

                if (VentasProductosDataGridView.DataSource != null)
                {
                    detalle = (List<ProductosDetalle>)VentasProductosDataGridView.DataSource;
                }
                decimal Total = 0;
                foreach (var item in detalle)
                {
                    Total = Convert.ToDecimal(TotalTextBox.Text);
                    Total -= item.Precio;
                }
                Total *= (-1);
                TotalTextBox.Text = Total.ToString();
            }
        }

        private void RevomerComboButton_Click(object sender, EventArgs e)
        {
            if (VentasComboDataGridView.Rows.Count > 0 && VentasComboDataGridView.CurrentRow != null)
            {
                this.DetalleC = (List<CombosDetalle>)VentasComboDataGridView.DataSource;
                DetalleC.RemoveAt(VentasComboDataGridView.CurrentRow.Index);
                CargarGridCombos();

                // Rebajar totales
                List<CombosDetalle> detalle = new List<CombosDetalle>();

                if (VentasComboDataGridView.DataSource != null)
                {
                    detalle = (List<CombosDetalle>)VentasComboDataGridView.DataSource;
                }
                decimal Total = 0;
                foreach (var item in detalle)
                { 
                    Total = Convert.ToDecimal(TotalTextBox.Text);
                    Total -= item.PrecioTotalCombo;
                }
                Total *= (-1);
                TotalTextBox.Text = Total.ToString();
            }
        }

        private void TotalTextBox_TextChanged(object sender, EventArgs e)
        {
            if(TotalTextBox.Text != null && EfectivoNumericUpDown.Value != 0)
            {
                decimal calculo;
                Decimal.TryParse(TotalTextBox.Text, out calculo);
                calculo = EfectivoNumericUpDown.Value - calculo;
                DevueltaTextBox.Text = calculo.ToString();
            }
        }

        private void EfectivoNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (TotalTextBox.Text != null && EfectivoNumericUpDown.Value != 0)
            {
                decimal calculo;
                Decimal.TryParse(TotalTextBox.Text, out calculo);
                calculo = EfectivoNumericUpDown.Value - calculo;
                DevueltaTextBox.Text = calculo.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InisioSesion().Show();
        }

    }
}
