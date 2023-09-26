using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webApi_HealthClinic.Domains
{
    public class MedicoDomain
    {
        [Key]
        public Guid IdMedico { get; set; } = Guid.NewGuid();


        [Required(ErrorMessage = "Usuário obrigatório")]
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public UsuarioDomain? Usuario { get; set; }


        [Required(ErrorMessage = "Clínica obrigatória")]
        public Guid IdClinica { get; set; }

        [ForeignKey(nameof(IdClinica))]
        public ClinicaDomain? Clinica { get; set; }


        [Required(ErrorMessage = "Especialidade obrigatória")]
        public Guid IdEspecialidade { get; set; }

        [ForeignKey(nameof(IdEspecialidade))]
        public EspecialidadeDomain Especialidade { get; set; }


        [Column(TypeName = "VARCHAR(20)")]
        [Required(ErrorMessage = "CRM é obrigatório!")]
        public string? CRM { get; set; }
    }
}
