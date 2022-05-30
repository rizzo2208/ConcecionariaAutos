using System.ComponentModel.DataAnnotations;

namespace ConcecionariaAutos.Entity
{
    public class Cliente
    {
        [Key]
        public int idCliente { get; set; }

        [Required]
        public string? Nombre { get; set; }

        [Required]
        public string? Apelido { get; set; }

        [Required]
        public string?dni { get; set; }

        [Required]
        public string? dieccion { get; set; }



    }
}
