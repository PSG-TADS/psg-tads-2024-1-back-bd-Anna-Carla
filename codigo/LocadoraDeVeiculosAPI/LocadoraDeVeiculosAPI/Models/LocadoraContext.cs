using Microsoft.EntityFrameworkCore;

namespace LocadoraDeVeiculosAPI.Models
{
    public class LocadoraContext : DbContext
    {
        public LocadoraContext(DbContextOptions<LocadoraContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Veiculo> Veiculo { get; set; }
        public DbSet<Reserva> Reserva { get; set; }

    }
}
