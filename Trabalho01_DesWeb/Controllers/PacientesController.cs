using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Trabalho01_DesWeb.Models;

namespace Trabalho01_DesWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacientesController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("Listagem de Pacientes");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok("Busca de paciente");
        }

        [HttpPost]
        public async Task<IActionResult> Post(DadosPacientes dados)
        {
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
