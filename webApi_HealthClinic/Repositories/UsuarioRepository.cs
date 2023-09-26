using webApi_HealthClinic.Domains;
using webApi_HealthClinic.Interfaces;

namespace webApi_HealthClinic.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public UsuarioDomain BuscarPorEmailESenha(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public UsuarioDomain BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(UsuarioDomain usuario)
        {
            throw new NotImplementedException();
        }
    }
}
