using webApi_HealthClinic.Domains;

namespace webApi_HealthClinic.Interfaces
{
    public interface IPacienteRepository
    {
        void Cadastrar(PacienteDomain novoPaciente);

        List<PacienteDomain> ListarTodos();

        PacienteDomain BuscarPorId(Guid id);

        void Atualizar(Guid Id, PacienteDomain paciente);

        void Deletar(Guid id);
    }
}
