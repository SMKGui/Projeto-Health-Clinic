using webapi.event_.tarde.Contexts;
using webApi_HealthClinic.Domains;
using webApi_HealthClinic.Interfaces;

namespace webApi_HealthClinic.Repositories
{
    public class ComentarioRepository : IComentarioRepository
    {
        private readonly HealthContext ctx;

        public ComentarioRepository()
        {
            ctx = new HealthContext();
        }

        public void Atualizar(Guid id, ComentarioDomain comentario)
        {
            ComentarioDomain comentarioBuscado = ctx.Comentario.Find(id);
            if (comentarioBuscado != null)
            {
                comentarioBuscado.Descricao = comentario.Descricao;
                comentarioBuscado.Exibe = comentario.Exibe;
                comentarioBuscado.IdUsuario = comentario.IdUsuario;
                
            }

            ctx.Update(comentarioBuscado);
            ctx.SaveChanges();
        }

        public ComentarioDomain BuscarPorId(Guid id)
        {
            try
            {
                ComentarioDomain comentarioBuscado = ctx.Comentario.Find(id);
                return comentarioBuscado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Comentar(ComentarioDomain novoComentario)
        {
            try
            {
                ctx.Comentario.Add(novoComentario);
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                ComentarioDomain comentario = ctx.Comentario.Find(id);

                if (comentario != null)
                {
                    ctx.Comentario.Remove(comentario);
                }
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ComentarioDomain> ListarTodos()
        {
            try
            {
                return ctx.Comentario.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
