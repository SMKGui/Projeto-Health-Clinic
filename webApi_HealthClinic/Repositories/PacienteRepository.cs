using webapi.event_.tarde.Contexts;
using webApi_HealthClinic.Domains;
using webApi_HealthClinic.Interfaces;

namespace webApi_HealthClinic.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly HealthContext ctx;

        public PacienteRepository()
        {
            ctx = new HealthContext();
        }

        public void Atualizar(Guid id, PacienteDomain paciente)
        {
            PacienteDomain pacienteBuscado = ctx.Paciente.Find(id);
            if (pacienteBuscado != null)
            {
                pacienteBuscado.DataNascimento = paciente.DataNascimento;
                pacienteBuscado.Telefone = paciente.Telefone;
                pacienteBuscado.CPF = paciente.CPF;
            }

            ctx.Update(especialidadeBuscada);
            ctx.SaveChanges();
        }

        public PacienteDomain BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(PacienteDomain novoPaciente)
        {
            try
            {
                ctx.Paciente.Add(novoPaciente);
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<PacienteDomain> ListarTodos()
        {
            try
            {
                return ctx.Paciente.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
