using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webApi_HealthClinic.Domains
{
    public class ComentarioDomain
    {
        [Key]
        public Guid IdComentario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Descrição obrigatória")]
        public string? Descricao { get; set; }

        [Column(TypeName = "BIT")]
        [Required(ErrorMessage = "Informação sobre exibição é obrigatória")]
        public bool? Exibe { get; set; }

        //ref.tabela Usuario
        [Required(ErrorMessage = "Usuário é obrigatório!")]
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public UsuarioDomain? Usuario { get; set; }
    }
}
