using EcommerceBlazor.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceBlazor.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Empleado> Empleados { get; set; }

    }
}

