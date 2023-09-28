using webapi.event_.tarde.Contexts;
using webApi_HealthClinic.Domains;
using webApi_HealthClinic.Interfaces;

namespace webApi_HealthClinic.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {

        private readonly HealthContext ctx;

        public TipoUsuarioRepository()
        {
            ctx = new HealthContext();
        }


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
            try
            {
                ctx.TipoUsuario.Add(tipoUsuario);

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
                TipoUsuarioDomain tipoUsuario = ctx.TipoUsuario.Find(id);

                if (tipoUsuario != null)
                {
                    ctx.TipoUsuario.Remove(tipoUsuario);
                }
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TipoUsuarioDomain> Listar()
        {
            try
            {
                return ctx.TipoUsuario.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
