using System.ComponentModel.DataAnnotations;

namespace PruebaIngresoFMP.Shared.Models
{
    public class Aspirantes
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "Ingrese su Identificacion.")]
        public long Identificacion { get; set; }
        [Required(ErrorMessage = "Ingrese sus Nombres.")]
        public string Nombres { get; set; } = null!;
        [Required(ErrorMessage = "Ingrese sus Apellidos.")]
        public string Apellidos { get; set; } = null!;
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }

        [Required(ErrorMessage = "Ingrese su correo electronico.")]
        [MinLength(3)]
        [EmailAddress(ErrorMessage = "email no valido")]
        [Display(Name = "Email")]
        public string Email { get; set; } = null!;
        public string? Usuario { get; set; }
        public DateTime? Fechaactualizacion { get; set; }
    }
}
