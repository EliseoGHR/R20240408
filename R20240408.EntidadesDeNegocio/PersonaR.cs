using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace R20240408.EntidadesDeNegocio
{
    public class PersonaR
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El nombre debe tener entre 2 y 50 caracteres")]
        [Display(Name = "Nombre")]
        public string NombreR { get; set; }

        [Required(ErrorMessage = "El Apellido es requerido")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El Apellido debe tener entre 2 y 50 caracteres")]
        [Display(Name = "Apellido")]
        public string ApellidoR { get; set; }     

        [Required(ErrorMessage = "Fecha de Nacimiento es requerido")]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimientoR { get; set; }

        [Required(ErrorMessage = "Sueldo es requerido")]
        [Display(Name = "Sueldo")]
        public decimal SueldoR { get; set; }

        [Required(ErrorMessage = "El estatus  es requerido.")]
        [Display(Name = "Estatus")]
        public byte EstatusR { get; set; }

        [StringLength(200, MinimumLength = 2, ErrorMessage = "EL Comentario debe tener entre 2 y 200 caracteres")]
        [Display(Name = "Comentario")]
        public string? ComentarioR { get; set; }

        [NotMapped]
        public int Take { get; set; }

    }
}
