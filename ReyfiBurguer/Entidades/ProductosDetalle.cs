using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReyfiBurguer.Entidades
{
    public class ProductosDetalle
    {
        public int ProductosDetalleId { get; set; }
        public int ProductoId { get; set; }
        public string NombreProducto { get; set; }
        public string TipoProducto { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }

        [ForeignKey("ProductoId")]
        public virtual Productos Producto { get; set; }

        public ProductosDetalle(int productosDetalleId, int productoId,string nombreProducto, string tipoProducto, decimal precio, string descripcion)
        {
            ProductosDetalleId = productosDetalleId;
            ProductoId = productoId;
            this.NombreProducto = nombreProducto;
            this.TipoProducto = tipoProducto;
            this.Precio = precio;
            this.Descripcion = descripcion;
        }

        public ProductosDetalle()
        {
            ProductosDetalleId = 0;
            ProductoId = 0;
            NombreProducto = string.Empty;
            TipoProducto = string.Empty;
            Precio = 0;
            Descripcion = string.Empty;
        }
    }
}
