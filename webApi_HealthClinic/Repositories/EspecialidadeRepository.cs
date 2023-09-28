using Microsoft.Data.SqlClient;
using webapi.event_.tarde.Contexts;
using webApi_HealthClinic.Domains;
using webApi_HealthClinic.Interfaces;

namespace webApi_HealthClinic.Repositories
{
    public class EspecialidadeRepository : IEspecialidadeRepository
    {
        private readonly HealthContext ctx;

        public EspecialidadeRepository()
        {
            ctx = new HealthContext();
        }


        public void Atualizar(Guid id, EspecialidadeDomain especialidade)
        {
            EspecialidadeDomain especialidadeBuscada = ctx.Especialidade.Find(id);
            if (especialidadeBuscada != null)
            {
                especialidadeBuscada.Nome = especialidade.Nome;               
            }

            ctx.Update(especialidadeBuscada);
            ctx.SaveChanges();
        }

        public EspecialidadeDomain BuscarPorId(Guid id)
        {
            try
            {
                EspecialidadeDomain especialidadeBuscada = ctx.Especialidade.Find(id);
                return especialidadeBuscada;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(EspecialidadeDomain novaEspecialidade)
        {
            try
            {
                ctx.Especialidade.Add(novaEspecialidade);
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
                EspecialidadeDomain especialidade = ctx.Especialidade.Find(id);

                if (especialidade != null)
                {
                    ctx.Especialidade.Remove(especialidade);
                }
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<EspecialidadeDomain> ListarTodos()
        {
            try
            {
                return ctx.Especialidade.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
