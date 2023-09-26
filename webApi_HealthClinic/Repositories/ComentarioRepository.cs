using webApi_HealthClinic.Domains;
using webApi_HealthClinic.Interfaces;

namespace webApi_HealthClinic.Repositories
{
    public class ComentarioRepository : IComentarioRepository
    {
        public void Atualizar(Guid Id, ComentarioDomain comentario)
        {
            throw new NotImplementedException();
        }

        public ComentarioDomain BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Comentar(ComentarioDomain novoComentario)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<ComentarioDomain> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
