using webApi_HealthClinic.Domains;

namespace webApi_HealthClinic.Interfaces
{
    public interface IComentarioRepository
    {
        void Comentar(ComentarioDomain novoComentario);

        List<ComentarioDomain> ListarTodos();

        ComentarioDomain BuscarPorId(Guid id);

        void Atualizar(Guid id, ComentarioDomain comentario);

        void Deletar(Guid id);
    }
}
