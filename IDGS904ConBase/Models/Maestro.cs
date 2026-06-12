using System.ComponentModel.DataAnnotations;

namespace IDGS904ConBase.Models
{
    public class Maestro
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(100)]
        public string Apaterno { get; set; }

        [StringLength(100)]
        public string Amaterno { get; set; }

        public string Especialidad { get; set; }

        public string Correo { get; set; }
    }
}