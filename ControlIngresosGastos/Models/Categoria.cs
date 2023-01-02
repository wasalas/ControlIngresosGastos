using System.ComponentModel.DataAnnotations;

namespace ControlIngresosGastos.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(120)]
        [Display(Name = "Nombre de Categoria")]
        public string NombreCategoria { get; set; }

        [Required]
        [MaxLength(1)]
        [Display(Name = "Tipo")]
        public string Tipo { get; set; } //[I]ngreso, [G]asto

        [Required]
        public bool Estado { get; set; }

    }
}
