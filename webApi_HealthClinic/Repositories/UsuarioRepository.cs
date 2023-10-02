using webapi.event_.tarde.Contexts;
using webApi_HealthClinic.Domains;
using webApi_HealthClinic.Interfaces;
using webApi_HealthClinic.Utils;

namespace webApi_HealthClinic.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly HealthContext _eventContext;

        public UsuarioRepository()
        {
            _eventContext = new HealthContext();
        }

        public UsuarioDomain BuscarPorEmailESenha(string email, string senha)
        {
            try
            {
                UsuarioDomain usuarioBuscado = _eventContext.Usuario.Select(u => new UsuarioDomain
                {
                    IdUsuario = u.IdUsuario,
                    Nome = u.Nome,
                    Email = u.Email,
                    Senha = u.Senha,
                    

                    TipoUsuario = new TipoUsuarioDomain()
                    {
                        IdTipoUsuario = u.IdTipoUsuario,
                        TituloUsuario = u.TipoUsuario!.TituloUsuario
                    }
                }).FirstOrDefault(u => u.Email == email)!;

                if (usuarioBuscado != null)
                {
                    bool confere = Criptografia.CompararHash(senha, usuarioBuscado.Senha!);
                    if (confere)
                    {
                        return usuarioBuscado;
                    }
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public UsuarioDomain BuscarPorId(Guid id)
        {
            try
            {
                UsuarioDomain usuarioBuscado = _eventContext.Usuario
                    .Select(u => new UsuarioDomain
                    {
                        IdUsuario = u.IdUsuario,
                        Nome = u.Nome,
                        Email = u.Email,

                        TipoUsuario = new TipoUsuarioDomain()
                        {
                            IdTipoUsuario = u.IdTipoUsuario,
                            TituloUsuario = u.TipoUsuario!.TituloUsuario
                        }
                    }).FirstOrDefault(u => u.IdUsuario == id);
                return usuarioBuscado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(UsuarioDomain usuario)
        {
            try
            {
                usuario.Senha = Criptografia.GerarHash(usuario.Senha);

                _eventContext.Usuario.Add(usuario);

                _eventContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
