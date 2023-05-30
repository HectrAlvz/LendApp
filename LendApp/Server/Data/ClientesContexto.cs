using LendApp.Shared.Modelo;
using Microsoft.EntityFrameworkCore;
// ReSharper disable All

namespace LendApp.Server.Data
{
    public class ClientesContexto : DbContext
    {
        public ClientesContexto(DbContextOptions<ClientesContexto> options) : base(options)
        {
        }

        public DbSet<Cliente>? Clientes { get; set; }

        public DbSet<LendApp.Shared.Modelo.Pago> Pago { get; set; } = default!;

        public DbSet<LendApp.Shared.Modelo.Prestamo> Prestamo { get; set; } = default!;

        
    }

    public class PrestamoContexto : DbContext
    {
        public PrestamoContexto(DbContextOptions<PrestamoContexto> options) : base(options)
        {
        }

        public DbSet<Prestamo>? Prestamos { get; set; }
        
        
    }

    public class PagoContexto : DbContext
    {
        public PagoContexto(DbContextOptions<PagoContexto> options) : base(options)
        {
        }
        
        public DbSet<Pago>? Pagos { get; set; }
        
        
    }
}