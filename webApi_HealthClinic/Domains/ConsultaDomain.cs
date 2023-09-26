using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using webApi_HealthClinic.Domains;

namespace webApi_HealthClinic.Domains
{
    public class ConsultaDomain
    {

        [Key]
        public Guid IdConsulta { get; set; } = Guid.NewGuid();


        [Required(ErrorMessage = "Médico é obrigatório")]
        public Guid IdMedico { get; set; }

        [ForeignKey(nameof(IdMedico))]
        public MedicoDomain? Medico { get; set; }


        [Required(ErrorMessage = "Paciente obrigatório")]
        public Guid IdPaciente { get; set; }

        [ForeignKey(nameof(IdPaciente))]
        public PacienteDomain? Paciente { get; set; }


        [Required(ErrorMessage = "O comentário é obrigatório!")]
        public Guid IdComentario { get; set; }

        [ForeignKey(nameof(IdComentario))]
        public ComentarioDomain? Comentario { get; set; }


        [Required(ErrorMessage = "Tipo de usuário obrigatório")]
        public Guid IdTipoUsuario { get; set; }

        [ForeignKey(nameof(IdTipoUsuario))]
        public TipoUsuarioDomain? TipoUsuario { get; set; }


        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "Data é obrigatória!")]
        public DateTime DataConsulta { get; set; }
    }
}
