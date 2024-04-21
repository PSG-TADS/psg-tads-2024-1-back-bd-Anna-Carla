using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LocadoraDeVeiculosAPI.Models
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
    }

