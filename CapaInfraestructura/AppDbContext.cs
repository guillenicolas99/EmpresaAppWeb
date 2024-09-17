using CapaDominio.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaInfraestructura
{
    public class AppDbContext : DbContext
    {
        private readonly DbContextOptions _context;

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }

        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
    }
}
