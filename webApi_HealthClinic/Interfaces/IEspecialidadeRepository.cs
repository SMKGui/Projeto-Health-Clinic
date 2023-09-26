using webApi_HealthClinic.Domains;

namespace webApi_HealthClinic.Interfaces
{
    public interface IEspecialidadeRepository
    {
        void Cadastrar(EspecialidadeDomain novaEspecialidade);

        List<EspecialidadeDomain> ListarTodos();

        EspecialidadeDomain BuscarPorId(Guid id);

        void Atualizar(Guid Id, EspecialidadeDomain especialidade);

        void Deletar(Guid id);
    }
}
