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
    public class ReservasController : ControllerBase
    {
        /// <summary>
        /// Objeto que irá receber todos os métodos da interface
        /// </summary>
        private IReservaRepository _reservaRepository { get; set; }
        private IProdutoRepository _produtoRepository { get; set; }


        /// <summary>
        /// Instancia o objeto para que haja referência às implementações no repositório
        /// </summary>
        public ReservasController()
        {
            _reservaRepository = new ReservaRepository();
            _produtoRepository = new ProdutoRepository();
        }


        /// <summary>
        /// Lista todas as Reservas existentes
        /// </summary>
        /// <returns>Uma lista de Reservas</returns>
        /// <summary>
        /// Lista todas as Reservas existentes
        /// </summary>
        /// <returns>Uma lista de Reservas</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_reservaRepository.Listar());
            }
            catch (Exception Erro)
            {
                return BadRequest(Erro);
            }
        }


        /// <summary>
        /// Busca um usuário através do ID
        /// </summary>
        /// <param name="Id">ID da Reserva que será buscado</param>
        /// <returns>Um usuário buscado e um status code 200 - Ok</returns>
        [HttpGet("{Id}")]
        public IActionResult GetById(int Id)
        {
            try
            {
                return Ok(_reservaRepository.BuscarPorId(Id));
            }
            catch (Exception Erro)
            {
                return BadRequest(Erro);
            }
        }


        /// <summary>
        /// Cadastra uma Reserva
        /// </summary>
        /// <param name="NovaReserva">Reserva a ser cadastrada</param>
        /// <returns>Um status code 201 - Created</returns>
        [HttpPost]
        public IActionResult CriarReserva(Reserva NovaReserva)
        {
            Produto p = _produtoRepository.BuscarPorId(NovaReserva.IdProduto);
            NovaReserva.IdUsuario = p.IdUsuario;

            _reservaRepository.FazerReserva(NovaReserva);

            return StatusCode(201);
        }

        [HttpPut("{Id}")]
        public IActionResult Put(int Id, Reserva ReservaAtualizada)
        {
            try
            {
                _reservaRepository.Editar(Id, ReservaAtualizada);
                return StatusCode(204);
            }
            catch (Exception Erro)
            {
                return BadRequest(Erro);
            }
        }


        /// <summary>
        /// Deleta um Reserva
        /// </summary>
        /// <param name="idReserva">id do Usuário a ser deletado</param>
        /// <returns>Um status code 204 - No content</returns>
        [HttpDelete("IdReserva")]
        public IActionResult Deletar(int idReserva)
        {
            _reservaRepository.Deletar(idReserva);

            return StatusCode(204);
        }
    }
}
