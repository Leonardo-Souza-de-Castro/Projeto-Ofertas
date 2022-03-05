﻿using Microsoft.AspNetCore.Http;
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
    public class ProdutosController : ControllerBase
    {
        private IProdutoRepository _produtoRepository { get; set; }
        public ProdutosController()
        {
            _produtoRepository = new ProdutoRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_produtoRepository.Listar());
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
                return Ok(_produtoRepository.BuscarPorId(Id));
            }
            catch (Exception Erro)
            {
                return BadRequest(Erro);
            }
        }

        [HttpPost]
        public IActionResult Post(Produto NovoProduto)
        {
            try
            {
                _produtoRepository.Cadastrar(NovoProduto);
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
                _produtoRepository.Deletar(Id);
                return StatusCode(204);
            }
            catch (Exception Erro)
            {
                return BadRequest(Erro);
            }
        }

        [HttpPut("{Id}")]
        public IActionResult Put(int Id, Produto ProdutoAtualizado)
        {
            try
            {
                _produtoRepository.Atualizar(Id, ProdutoAtualizado);
                return StatusCode(204);
            }
            catch (Exception Erro)
            {
                return BadRequest(Erro);
            }
        }
    }
}
