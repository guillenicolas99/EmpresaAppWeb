using CapaInfraestructura;
using Microsoft.AspNetCore.Mvc;

namespace EmpresaApp.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly AppDbContext _context;

        public CategoriaController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var categorias = _context.Categorias.ToList();
            return View(categorias);
        }
    }
}
