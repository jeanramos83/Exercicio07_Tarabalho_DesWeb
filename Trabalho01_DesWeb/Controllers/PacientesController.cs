using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Trabalho01_DesWeb.Models;
using Trabalho01_DesWeb.Repositories;

namespace Trabalho01_DesWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacientesController : ControllerBase
    {
        private PacienteRepository _repository;

        public PacientesController()
        {
            _repository = new PacienteRepository();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_repository.ListaTodosPacientes());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok("Busca de paciente");
        }

        [HttpPost]
        public async Task<IActionResult> Post(DadosPacientes dados)
        {
            _repository.InserePaciente;
            return Ok("Registrar novo paciente");
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, DadosPacientes dados)
        {
            return Ok("Paciente atualizado com sucesso!");
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok("Paciente removido com sucesso!");
        }
    }
}
