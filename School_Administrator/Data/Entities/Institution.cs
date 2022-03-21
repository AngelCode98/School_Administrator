using System.ComponentModel.DataAnnotations;

namespace School_Administrator.Data.Entities
{
    public class Institution
    {
        public int Id { get; set; }

        [Display(Name = "Intitución")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }
    }
}
