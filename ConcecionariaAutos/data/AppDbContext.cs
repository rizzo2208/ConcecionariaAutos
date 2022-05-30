using ConcecionariaAutos.Entity;
using Microsoft.EntityFrameworkCore;


namespace ConcecionariaAutos.data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Venta>? Ventas { get; set; }
        public DbSet<Cliente>? Clientes { get; set; } 
        public DbSet<Vehiculo>? Vehiculos { get; set; }
    }
}
