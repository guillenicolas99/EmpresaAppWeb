using CapaDominio.Entities;
using CapaInfraestructura;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EmpresaApp.Controllers
{
    public class ProductoController : Controller
    {
        private readonly AppDbContext _context;

        public ProductoController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var productos = _context.Productos.Include(p => p.Categoria).ToList();
            return View(productos);
        }

        public IActionResult _Create()
        {
            var categorias = _context.Categorias.ToList();
            if (categorias == null)
            {
                categorias = new List<Categorias>(); // Evitar que sea null
            }

            ViewBag.Categorias = categorias;
            return PartialView("_Create", new Producto());
        }

        public IActionResult CategoriaSelectList()
        {
            var categorias = _context.Categorias.ToList(); // Obtener todas las categorías
            return PartialView("_categoriaList");
        }
    }
}
