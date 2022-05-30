using System.ComponentModel.DataAnnotations;

namespace ConcecionariaAutos.Entity
{
    public class Vehiculo
    {
        [Key]
        public int idVehculo { get; set; }

        [Required]
        public string? marca { get; set; }

        [Required]
        public string? modelo { get; set; }

        [Required]
        public float precio { get; set; }

        [DataType(DataType.Date)]
        public DateTime fechaBaja { get; set; }


    }
}
