using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace webApi_HealthClinic.Domains
{
    public class PacienteDomain
    {
        [Key]
        public Guid IdPaciente { get; set; } = Guid.NewGuid();

        [ForeignKey(nameof(IdUsuario))]
        public Guid IdUsuario { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "A data de nascimento é obrigatória!")]
        public DateTime DataNascimento { get; set; }

        [Column(TypeName = "VARCHAR(20)")]
        [Required(ErrorMessage = "O telefone é obrigatório!")]
        public string? Telefone { get; set; }

        [Column(TypeName = "VARCHAR(11)")]
        [Required(ErrorMessage = "O CPF é obrigatório!")]
        public string? CPF { get; set; }
    }
}
