using webapi.event_.tarde.Contexts;
using webApi_HealthClinic.Domains;
using webApi_HealthClinic.Interfaces;

namespace webApi_HealthClinic.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        private readonly HealthContext ctx;

        public ConsultaRepository()
        {
            ctx = new HealthContext();
        }

        public void Atualizar(Guid id, ConsultaDomain consulta)
        {
            ConsultaDomain consultaBuscada = ctx.Consulta.Find(id);
            if (consultaBuscada != null)
            {
                consultaBuscada.IdMedico = consulta.IdMedico;
                consultaBuscada.IdPaciente = consulta.IdPaciente;
                consultaBuscada.IdComentario = consulta.IdComentario;
                consultaBuscada.IdTipoUsuario = consulta.IdTipoUsuario;
                consultaBuscada.DataConsulta = consulta.DataConsulta;               
            }

            ctx.Update(consultaBuscada);
            ctx.SaveChanges();
        }

        public ConsultaDomain BuscarPorId(Guid id)
        {
            try
            {
                ConsultaDomain consulta = ctx.Consulta.Find(id);
                return consulta;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(ConsultaDomain novaConsulta)
        {
            try
            {
                ctx.Consulta.Add(novaConsulta);
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
                ConsultaDomain consulta = ctx.Consulta.Find(id);

                if (consulta != null)
                {
                    ctx.Consulta.Remove(consulta);
                }
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ConsultaDomain> ListarTodos()
        {
            try
            {
                return ctx.Consulta.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
