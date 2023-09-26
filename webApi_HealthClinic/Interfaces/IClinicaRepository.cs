using webApi_HealthClinic.Domains;

namespace webApi_HealthClinic.Interfaces
{
    public interface IClinicaRepository
    {
        void Cadastrar(ClinicaDomain novaCLinica);

        List<ClinicaDomain> ListarTodos();

        ClinicaDomain BuscarPorId(Guid id);

        void Atualizar(Guid Id, ClinicaDomain clinica);

        void Deletar(Guid id);
    }
}
