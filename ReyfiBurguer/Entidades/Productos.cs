
using System.ComponentModel.DataAnnotations;

namespace ReyfiBurguer.Entidades
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public string NombreProducto { get; set; }
        public decimal Precio { get; set; }

        public Productos()
        {
            ProductoId = 0;
            NombreProducto = string.Empty;
            Precio = 0;
        }
    }
}
