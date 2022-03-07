using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_harmony_webAPI.Interfaces;
using senai_harmony_webAPI.Repositories;
using System;

namespace senai_harmony_webAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TipoProdutoController : ControllerBase
    {
        private ITipoProdutoRepository _tipoprodutoRepository { get; set; }
        public TipoProdutoController()
        {
            _tipoprodutoRepository = new TipoProdutoRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_tipoprodutoRepository.Listar());
            }
            catch (Exception Erro)
            {
                return BadRequest(Erro);
            }
        }
    }
}
