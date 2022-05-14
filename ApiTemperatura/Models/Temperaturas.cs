using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiTemperatura.Models
{
    public class Temperaturas
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string NombreCiudad { get; set; }

        [Required]
        public double Temperatura { get; set; }

    }
}
