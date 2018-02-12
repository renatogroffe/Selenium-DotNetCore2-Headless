using System.ComponentModel.DataAnnotations;

namespace ConversorDistancias.Models
{
    public class DistanciasViewModel
    {
        [Range(0.01, 9999999.99)]
        [Required]
        public double? DistanciaMilhas { get; set; }

        public double? DistanciaKm { get; set; }
    }
}
