using Microsoft.EntityFrameworkCore;

namespace LocadoraAPI.Models
{
    public class LocadoraContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Veiculo> Veiculo { get; set; }
        public DbSet<Reserva> Reserva { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _ = optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=ORM;Trusted_Connection=True;TrustServerCertificate=true;");
        }

    }
    
}
