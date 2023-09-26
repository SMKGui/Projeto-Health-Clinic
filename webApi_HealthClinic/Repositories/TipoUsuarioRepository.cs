using webApi_HealthClinic.Domains;
using webApi_HealthClinic.Interfaces;

namespace webApi_HealthClinic.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        public void Atualizar(Guid id, TipoUsuarioDomain tipoUsuario)
        {
            throw new NotImplementedException();
        }

        public TipoUsuarioDomain BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(TipoUsuarioDomain tipoUsuario)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<TipoUsuarioDomain> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
