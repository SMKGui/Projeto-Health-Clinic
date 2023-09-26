using webApi_HealthClinic.Domains;
using webApi_HealthClinic.Interfaces;

namespace webApi_HealthClinic.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        public void Atualizar(Guid Id, ConsultaDomain consulta)
        {
            throw new NotImplementedException();
        }

        public ConsultaDomain BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(ConsultaDomain novaConsulta)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<ConsultaDomain> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
