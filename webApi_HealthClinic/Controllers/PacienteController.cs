﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webApi_HealthClinic.Domains;
using webApi_HealthClinic.Interfaces;
using webApi_HealthClinic.Repositories;

namespace webApi_HealthClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class PacienteController : ControllerBase
    {
        private IPacienteRepository _pacienteRepository { get; set; }

        public PacienteController()
        {
            _pacienteRepository = new PacienteRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                List<PacienteDomain> listaPaciente = _pacienteRepository.ListarTodos();
                return Ok(listaPaciente);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Cadastrar(PacienteDomain paciente)
        {
            try
            {
                _pacienteRepository.Cadastrar(paciente);

                return StatusCode(201);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public IActionResult Atualizar(Guid id, PacienteDomain paciente)
        {
            try
            {
                _pacienteRepository.Atualizar(id, paciente);
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
                _pacienteRepository.Deletar(id);
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
                PacienteDomain pacienteBuscado = _pacienteRepository.BuscarPorId(id);
                return Ok(pacienteBuscado);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
