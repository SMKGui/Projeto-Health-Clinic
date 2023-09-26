using webApi_HealthClinic.Domains;

namespace webApi_HealthClinic.Interfaces
{
    public interface IUsuarioRepository
    {
        void Cadastrar(UsuarioDomain usuario);

        UsuarioDomain BuscarPorId(Guid id);

        UsuarioDomain BuscarPorEmailESenha(string email, string senha);
    }
}

