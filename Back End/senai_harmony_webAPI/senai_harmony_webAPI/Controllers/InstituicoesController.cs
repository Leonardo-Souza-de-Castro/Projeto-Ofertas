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
    public class InstituicoesController : ControllerBase
    {
        private IInstituicaoRepository _instituicaoRepository { get; set; }
        public InstituicoesController()
        {
            _instituicaoRepository = new InstituicaoRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_instituicaoRepository.Listar());
            }
            catch (Exception Erro)
            {
                return BadRequest(Erro);
            }
        }

        [HttpGet("{Id}")]
        public IActionResult GetById(int Id)
        {
            try
            {
                return Ok(_instituicaoRepository.BuscarPorId(Id));
            }
            catch (Exception Erro)
            {
                return BadRequest(Erro);
            }
        }

        [HttpPost]
        public IActionResult Post(Instituicao NovaInstituicao)
        {
            try
            {
                _instituicaoRepository.Cadastrar(NovaInstituicao);

                return StatusCode(201);
            }
            catch (Exception Erro)
            {
                return BadRequest(Erro);
            }
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            try
            {
                _instituicaoRepository.Deletar(Id);
                return StatusCode(204);
            }
            catch (Exception Erro)
            {
                return BadRequest(Erro);
            }
        }

        [HttpPut("{Id}")]
        public IActionResult Put(int Id, Instituicao InstituicaoAtualizada)
        {
            try
            {
                _instituicaoRepository.Atualizar(Id, InstituicaoAtualizada);
                return StatusCode(204);
            }
            catch (Exception Erro)
            {
                return BadRequest(Erro);
            }
        }
    }
}
