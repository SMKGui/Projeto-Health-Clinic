using webApi_HealthClinic.Domains;
using webApi_HealthClinic.Interfaces;

namespace webApi_HealthClinic.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        public void Atualizar(Guid Id, PacienteDomain paciente)
        {
            throw new NotImplementedException();
        }

        public PacienteDomain BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(PacienteDomain novoPaciente)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<PacienteDomain> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
