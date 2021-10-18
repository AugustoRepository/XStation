using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XStation.Presentation.Model;
using XStation.Repository.Entities;
using XStation.Repository.Interfaces;
using XStation.Repository.Repositories;

namespace XStation.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(ClienteCadastroModel model
            ,[FromServices] ClienteRepository produtoRepository)
        {
            try
            {
                var cliente = new Cliente();

                cliente.Nome = model.Nome;
                cliente.Cpf = model.Cpf;
                cliente.Telefone1 = model.Telefone1;
                cliente.Telefone2 = model.Telefone2;
                cliente.DataCriacao = DateTime.Now;
                cliente.DataNascimento = model.DataNascimento;
                return Ok("Produto cadastrado com sucesso.");
            }
            catch (Exception e)
            {
                return StatusCode(500, "Ocorreu um erro: " + e.Message);
            }
        }
        [HttpPut]
        public IActionResult Put()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult GetById()
        {
            return Ok();
        }
    }
}
