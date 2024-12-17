using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EcommerceBlazor.Data;
using EcommerceBlazor.Model;

namespace EcommerceBlazor.Data
{
    public class EcommerceBlazorContext : IdentityDbContext<EcommerceBlazorUser>
    {
        public EcommerceBlazorContext(DbContextOptions<EcommerceBlazorContext> options) : base(options) { }

        public DbSet<Producto> Producto { get; set; }
        public DbSet<Empleados> Empleado { get; set; }
        public DbSet<Stock> EcommerceBlazor { get; set; }
    }
}
