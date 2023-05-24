using LendApp.Shared.Modelo;
using Microsoft.EntityFrameworkCore;

namespace LendApp.Server.Data
{
    public class ClientesContexto : DbContext
    {
        public ClientesContexto(DbContextOptions<ClientesContexto> options) : base(options)
        {
        }

        public DbSet<Cliente>? Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .HasOne(c => c.Prestamo)
                .WithOne(p => p.Cliente)
                .HasForeignKey<Prestamo>(p => p.ClienteId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Cliente>()
                .HasMany(c => c.Pagos)
                .WithOne(p => p.Cliente)
                .HasForeignKey(p => p.ClienteId)
                .OnDelete(DeleteBehavior.NoAction);
        }

        public DbSet<LendApp.Shared.Modelo.Pago> Pago { get; set; } = default!;

        public DbSet<LendApp.Shared.Modelo.Prestamo> Prestamo { get; set; } = default!;
    }

    public class PrestamoContexto : DbContext
    {
        public PrestamoContexto(DbContextOptions<PrestamoContexto> options) : base(options)
        {
        }

        public DbSet<Prestamo>? Prestamos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Prestamo>()
                .HasOne(p => p.Cliente)
                .WithOne(c => c.Prestamo)
                .HasForeignKey<Cliente>(c => c.PrestamoId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }

    public class PagoContexto : DbContext
    {
        public PagoContexto(DbContextOptions<PagoContexto> options) : base(options)
        {
        }

        public DbSet<Pago>? Pagos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pago>()
                .HasOne(p => p.Cliente)
                .WithMany(c => c.Pagos)
                .HasForeignKey(p => p.ClienteId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Pago>()
                .HasOne(p => p.Prestamo)
                .WithMany()
                .HasForeignKey(p => p.PrestamoId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}