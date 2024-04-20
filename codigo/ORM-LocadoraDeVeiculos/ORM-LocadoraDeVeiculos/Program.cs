using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;

namespace ORM_LocadoraDeVeiculos
{
    internal class Program
    {
        public class Cliente
        {
            [Key]
            public int Id { get; set; }
            public string? Nome { get; set; }
            public string? CPF { get; set; }
            public string? Telefone { get; set; }
            public string? Endereco { get; set; }
            public ICollection<Reserva>? Reservas { get; set; }
        }

        public class Veiculo
        {
            [Key]
            public int Id { get; set; }
            public string? Placa { get; set; }
            public string? Modelo { get; set; }
            public int Ano { get; set; }
            public float ValorDiaria { get; set; }
            public bool Alugado { get; set; }
            public int? ReservaID { get; set; }
            [ForeignKey("ReservaID")]
            public string? Reserva { get; set; }
        }

        public class Reserva
        {
            [Key]
            public int Id { get; set; }
            public DateTime DataRetirada { get; set; }
            public DateTime DataDevolucao { get; set; }
            public int? ClienteID { get; set; }
            [ForeignKey("ClienteID")]
            public string? Cliente { get; set; }
        }

        // Classe para contexto de conexão
        public class ApplicationContext : DbContext
        {
            public DbSet<Cliente> Cliente { get; set; }
            public DbSet<Veiculo> Veiculo { get; set; }
            public DbSet<Reserva> Reserva { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                _ = optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=ORM;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }

        static void Main(string[] args)
        {

        }
    }
}
