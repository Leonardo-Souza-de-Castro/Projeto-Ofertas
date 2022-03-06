using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_harmony_webAPI.Domains;
using senai_harmony_webAPI.Interfaces;
using senai_harmony_webAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_harmony_webAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecosController : ControllerBase
    {
        private IEnderecoRepository _enderecoRepository { get; set; }
        public EnderecosController()
        {
            _enderecoRepository = new EnderecoRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_enderecoRepository.Listar());
            }
            catch (Exception Erro)
            {
                return BadRequest(Erro);
            }
        }

        [HttpPost]
        public IActionResult Post(Endereco NovoEndereco)
        {
            try
            {
                _enderecoRepository.Cadastrar(NovoEndereco);

                return StatusCode(201);
            }
            catch (Exception Erro)
            {
                return BadRequest(Erro);
            }
        }

    }
}
