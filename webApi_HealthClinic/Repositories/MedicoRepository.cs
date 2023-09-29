using webapi.event_.tarde.Contexts;
using webApi_HealthClinic.Domains;
using webApi_HealthClinic.Interfaces;

namespace webApi_HealthClinic.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        private readonly HealthContext ctx;

        public MedicoRepository()
        {
            ctx = new HealthContext();
        }


        public void Atualizar(Guid id, MedicoDomain medico)
        {
            MedicoDomain medicoBuscado = ctx.Medico.Find(id);
            if (medicoBuscado != null)
            {
                medicoBuscado.IdUsuario = medico.IdUsuario;
                medicoBuscado.IdClinica = medico.IdClinica;
                medicoBuscado.IdEspecialidade = medico.IdEspecialidade;
                medicoBuscado.CRM = medico.CRM;             
            }

            ctx.Update(medicoBuscado);
            ctx.SaveChanges();
        }

        public MedicoDomain BuscarPorId(Guid id)
        {
            try
            {
                MedicoDomain medicoBuscado = ctx.Medico.FirstOrDefault(a => a.IdMedico == id);
                return medicoBuscado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(MedicoDomain novoMedico)
        {
            try
            {
                ctx.Medico.Add(novoMedico);
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
                MedicoDomain medico = ctx.Medico.Find(id);
                if (medico != null)
                {
                    ctx.Medico.Remove(medico);
                }
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<MedicoDomain> ListarTodos()
        {
            try
            {
                return ctx.Medico.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
