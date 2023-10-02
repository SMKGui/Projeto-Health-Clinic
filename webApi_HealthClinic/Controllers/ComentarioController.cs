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
    public class ComentarioController : ControllerBase
    {
        private IComentarioRepository _comentarioRepository { get; set; }

        public ComentarioController()
        {
            _comentarioRepository = new ComentarioRepository();
        }

        [HttpGet]
        public IActionResult ListarTodos()
        {
            try
            {
                List<ComentarioDomain> listaComentario = _comentarioRepository.ListarTodos();
                return Ok(listaComentario);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        [HttpPost]
        public IActionResult Comentar(ComentarioDomain novoComentario)
        {
            try
            {
                _comentarioRepository.Comentar(novoComentario);

                return StatusCode(201);
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
                _comentarioRepository.Deletar(id);
                return NoContent();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(Guid id, ComentarioDomain comentario)
        {
            try
            {
                _comentarioRepository.Atualizar(id, comentario);
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
                ComentarioDomain comentarioBuscado = _comentarioRepository.BuscarPorId(id);
                return Ok(comentarioBuscado);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
