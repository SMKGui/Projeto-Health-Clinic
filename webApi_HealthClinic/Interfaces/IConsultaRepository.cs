using webApi_HealthClinic.Domains;

namespace webApi_HealthClinic.Interfaces
{
    public interface IConsultaRepository
    {
        void Cadastrar(ConsultaDomain novaConsulta);

        List<ConsultaDomain> ListarTodos();

        ConsultaDomain BuscarPorId(Guid id);

        void Atualizar(Guid id, ConsultaDomain consulta);

        void Deletar(Guid id);
    }
}
