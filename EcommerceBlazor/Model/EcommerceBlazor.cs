using EcommerceBlazor.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceBlazor.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Producto> Productos { get; set; }
    }
}
