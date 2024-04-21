using System.ComponentModel.DataAnnotations;

namespace LocadoraAPI.Models
{
    public class Cliente
    {

        [Key]
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public string? Telefone { get; set; }
        public string? Endereco { get; set; }
        public List<Reserva>? Reservas { get; set; }
        public object Reserva { get; internal set; }

        public Cliente()
        {
            Reservas = null;
        }
    }
}
