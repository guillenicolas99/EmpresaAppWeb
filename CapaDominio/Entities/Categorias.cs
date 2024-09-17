using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entities
{
    public class Categorias
    {
        [Key]
        public int NoCategoria { get; set; }

        [Required(ErrorMessage = "El nombre de la categría es obligatorio")]
        public string NombreCategoria{ get; set; }
        public string Descripcion { get; set; }

        //RELACION CON ENTIDAD PRODUCTO
        public ICollection<Producto> Productos { get; set; } = new List<Producto>();
    }
}
