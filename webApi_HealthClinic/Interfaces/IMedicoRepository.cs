using webApi_HealthClinic.Domains;

namespace webApi_HealthClinic.Interfaces
{
    public interface IMedicoRepository
    {

        void Cadastrar(MedicoDomain novoMedico);

        List<MedicoDomain> ListarTodos();

        MedicoDomain BuscarPorId(Guid id);

        void Atualizar(Guid id, MedicoDomain medico);

        void Deletar(Guid id);
    }
}
