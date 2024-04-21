using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LocadoraDeVeiculosAPI.Models
{
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

}
