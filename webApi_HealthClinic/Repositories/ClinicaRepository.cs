using webapi.event_.tarde.Contexts;
using webApi_HealthClinic.Domains;
using webApi_HealthClinic.Interfaces;

namespace webApi_HealthClinic.Repositories
{
    public class ClinicaRepository : IClinicaRepository
    {
        private readonly HealthContext ctx;

        public ClinicaRepository()
        {
            ctx = new HealthContext();
        }

        public void Atualizar(Guid id, ClinicaDomain clinica)
        {
            ClinicaDomain clinicaBuscada = ctx.Clinica.Find(id);
            if (clinicaBuscada != null)
            {
                clinicaBuscada.Endereco = clinica.Endereco;
                clinicaBuscada.NomeFantasia = clinica.NomeFantasia;               
            }

            ctx.Update(clinicaBuscada);
            ctx.SaveChanges();
        }

        public ClinicaDomain BuscarPorId(Guid id)
        {
            try
            {
                ClinicaDomain clinicaBuscada = ctx.Clinica.Find(id);
                return clinicaBuscada;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(ClinicaDomain novaCLinica)
        {
            try
            {
                ctx.Clinica.Add(novaCLinica);
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                ClinicaDomain clinica = ctx.Clinica.Find(id);

                if (clinica != null)
                {
                    ctx.Clinica.Remove(clinica);
                }
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ClinicaDomain> ListarTodos()
        {
            try
            {
                return ctx.Clinica.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
