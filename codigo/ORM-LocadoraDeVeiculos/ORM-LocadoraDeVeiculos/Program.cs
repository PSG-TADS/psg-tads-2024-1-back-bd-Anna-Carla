using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
            public int? ReservaID { get; set; }
            [ForeignKey("ReservaID")]
            public string? Reserva { get; set; }

        }

        public class  Reserva
        {
            [Key]
            public int Id { get; set; }
            public string? DataRetirada { get; set; }
            public string? DataDevolucao { get; set; }
            public int? ClienteID { get; set; }
            [ForeignKey("ClienteID")]
            public string? Cliente { get; set;}

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
