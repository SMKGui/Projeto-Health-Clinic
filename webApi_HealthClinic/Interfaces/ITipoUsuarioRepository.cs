using webApi_HealthClinic.Domains;

namespace webApi_HealthClinic.Interfaces
{
    public interface ITipoUsuarioRepository
    {
        void Cadastrar(TipoUsuarioDomain tipoUsuario);

        void Deletar(Guid id);

        List<TipoUsuarioDomain> Listar();

        TipoUsuarioDomain BuscarPorId(Guid id);

        void Atualizar(Guid id, TipoUsuarioDomain tipoUsuario);
    }
}
