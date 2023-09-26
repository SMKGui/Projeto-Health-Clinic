using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webApi_HealthClinic.Domains
{
    public class EspecialidadeDomain
    {
        [Key]
        public Guid IdEspecialidade { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(30)")]
        [Required(ErrorMessage = "Nome é obrigatório!")]
        public string? Nome { get; set; }
    }
}
