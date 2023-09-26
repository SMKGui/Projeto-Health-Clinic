using webApi_HealthClinic.Domains;
using webApi_HealthClinic.Interfaces;

namespace webApi_HealthClinic.Repositories
{
    public class ClinicaRepository : IClinicaRepository
    {
        public void Atualizar(Guid Id, ClinicaDomain clinica)
        {
            throw new NotImplementedException();
        }

        public ClinicaDomain BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(ClinicaDomain novaCLinica)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<ClinicaDomain> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
