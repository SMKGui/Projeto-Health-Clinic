﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webApi_HealthClinic.Domains
{
    [Table(nameof(UsuarioDomain))]
    [Index(nameof(Email), IsUnique = true)]
    public class UsuarioDomain
    {
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome é obrigatório!")]
        public string? Nome { get; set; }


        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Email é obrigatório!")]
        public string? Email { get; set; }

        [Column(TypeName = "CHAR(60)")]
        [Required(ErrorMessage = "Senha é obrigatória!")]
        [StringLength(60, MinimumLength = 6, ErrorMessage = "Senha deve conter de 6 a 60 caracteres")]
        public string? Senha { get; set; }

        //ref.tabela TipoUsuario = FK
        [Required(ErrorMessage = "O tipo do usuário é obrigatório!")]
        public Guid IdTipoUsuario { get; set; }

        [ForeignKey(nameof(IdTipoUsuario))]
        public TipoUsuarioDomain? TipoUsuario { get; set; }
    }
}

