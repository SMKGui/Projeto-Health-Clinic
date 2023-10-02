using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webApi_HealthClinic.Domains;
using webApi_HealthClinic.Interfaces;
using webApi_HealthClinic.Repositories;

namespace webApi_HealthClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ConsultaController : ControllerBase
    {
        private IConsultaRepository _consultaRepository { get; set; }

        public ConsultaController()
        {
            _consultaRepository = new ConsultaRepository();
        }

        [HttpGet]
        public IActionResult ListarTodos()
        {
            try
            {
                List<ConsultaDomain> listaConsulta = _consultaRepository.ListarTodos();
                return Ok(listaConsulta);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Cadastrar(ConsultaDomain consulta)
        {
            try
            {
                _consultaRepository.Cadastrar(consulta);

                return StatusCode(201);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(Guid id, ConsultaDomain consulta)
        {
            try
            {
                _consultaRepository.Atualizar(id, consulta);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(Guid id)
        {
            try
            {
                _consultaRepository.Deletar(id);
                return NoContent();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }


        [HttpGet("{id}")]
        public IActionResult BuscarPorId(Guid id)
        {
            try
            {
                ConsultaDomain consultaBuscada = _consultaRepository.BuscarPorId(id);
                return Ok(consultaBuscada);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
