using webApi_HealthClinic.Domains;
using webApi_HealthClinic.Interfaces;

namespace webApi_HealthClinic.Repositories
{
    public class EspecialidadeRepository : IEspecialidadeRepository
    {
        public void Atualizar(Guid Id, EspecialidadeDomain especialidade)
        {
            throw new NotImplementedException();
        }

        public EspecialidadeDomain BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(EspecialidadeDomain novaEspecialidade)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<EspecialidadeDomain> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
