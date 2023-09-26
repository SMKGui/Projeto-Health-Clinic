using Microsoft.EntityFrameworkCore;
using webApi_HealthClinic.Domains;

namespace webapi.event_.tarde.Contexts
{
    public class HealthContext : DbContext
    {
        public DbSet<TipoUsuarioDomain> TipoUsuario { get; set; }
        public DbSet<UsuarioDomain> Usuario { get; set; }
        public DbSet<PacienteDomain> Paciente { get; set; }
        public DbSet<MedicoDomain> Medico { get; set; }
        public DbSet<EspecialidadeDomain> Especialidade { get; set; }
        public DbSet<ConsultaDomain> Consulta { get; set; }
        public DbSet<ComentarioDomain> Comentario { get; set; }
        public DbSet<ClinicaDomain> Clinica { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-8UO2UT6; Database = HealthClinic_API; User Id = sa; Password = Senai@134; TrustServerCertificate = True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
