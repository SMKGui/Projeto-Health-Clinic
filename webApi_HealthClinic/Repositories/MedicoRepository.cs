using webApi_HealthClinic.Domains;
using webApi_HealthClinic.Interfaces;

namespace webApi_HealthClinic.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        public void Atualizar(Guid Id, MedicoDomain medico)
        {
            throw new NotImplementedException();
        }

        public MedicoDomain BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(MedicoDomain novoMedico)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<MedicoDomain> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
