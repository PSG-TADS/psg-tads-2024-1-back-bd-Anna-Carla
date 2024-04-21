using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LocadoraDeVeiculosAPI.Models
{
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
    }