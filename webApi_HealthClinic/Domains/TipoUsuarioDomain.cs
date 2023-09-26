﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webApi_HealthClinic.Domains
{
    [Table(nameof(TipoUsuarioDomain))]
    public class TipoUsuarioDomain
    {
        [Key]
        public Guid IdTipoUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Título do tipo de Usuário")]
        public string? TituloUsuario { get; set; }
    }

}
