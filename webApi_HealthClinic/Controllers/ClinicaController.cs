using Microsoft.AspNetCore.Authorization;
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
    public class ClinicaController : ControllerBase
    {
        private IClinicaRepository _clinicaRepository { get; set; }

        public ClinicaController()
        {
            _clinicaRepository = new ClinicaRepository();
        }

        [HttpGet]
        //[Authorize (Roles ="Admin")]
        public IActionResult ListarTodos()
        {
            try
            {
                List<ClinicaDomain> listaClinica = _clinicaRepository.ListarTodos();
                return Ok(listaClinica);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Cadastrar(ClinicaDomain clinica)
        {
            try
            {
                _clinicaRepository.Cadastrar(clinica);

                return StatusCode(201);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }


        [HttpPut("{id}")]
        public IActionResult Atualizar(Guid id, ClinicaDomain clinica)
        {
            try
            {
                _clinicaRepository.Atualizar(id, clinica);
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
                _clinicaRepository.Deletar(id);
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
                ClinicaDomain clinicaBuscada = _clinicaRepository.BuscarPorId(id);
                return Ok(clinicaBuscada);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

    }
}
