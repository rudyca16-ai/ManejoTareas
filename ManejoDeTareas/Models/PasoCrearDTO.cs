using System.ComponentModel.DataAnnotations;

namespace ManejoDeTareas.Models
{
    public class PasoCrearDTO
    {
        [Required]
        public string Descripcion { get; set; }
        public bool Realizado { get; set; }
    }
}
