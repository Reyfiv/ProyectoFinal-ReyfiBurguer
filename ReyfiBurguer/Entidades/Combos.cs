﻿
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReyfiBurguer.Entidades
{
    public class Combos
    {
        [Key]
        public int ComboId { get; set; }
        public string NombreCombo { get; set; }
        public virtual List<ProductosDetalle> Producto { get; set; }
        public decimal PrecioTotalCombo { get; set; }

        public Combos()
        {
            ComboId = 0;
            NombreCombo = string.Empty;
            Producto = new List<ProductosDetalle>();
            PrecioTotalCombo = 0;
        }

      
    }
}
