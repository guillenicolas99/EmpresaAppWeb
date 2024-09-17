using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entities
{
    public class Producto
    {
        [Key]
        public int NoProducto { get; set; }

        [Required(ErrorMessage = "El nombre del producto es requerido")]
        public string NombreProduto { get; set; }

        public string Description { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "El stock debe ser mayor o igual a 0")]
        public int Stock { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "El precio debe ser mayor o igual a 0")]
        public double PrecioVenta { get; set; }

        //RELACION TABLA CATEGORIA
        [Required(ErrorMessage = "Seleccione una categoria")]
        public int NoCategoria { get; set; }
        public Categorias? Categoria { get; set; }
    }
}
