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
        private IReservaRepository _reservaRepository { get; set; }
<<<<<<< HEAD
=======
        private IProdutoRepository _produtoRepository { get; set; }


        /// <summary>
        /// Instancia o objeto para que haja referência às implementações no repositório
        /// </summary>
>>>>>>> 15071d622255deff899ace532b96eb6019e1dd24
        public ReservasController()
        {
            _reservaRepository = new ReservaRepository();
            _produtoRepository = new ProdutoRepository();
        }

<<<<<<< HEAD
=======

        /// <summary>
        /// Lista todas as Reservas existentes
        /// </summary>
        /// <returns>Uma lista de Reservas</returns>
        /// <summary>
        /// Lista todas as Reservas existentes
        /// </summary>
        /// <returns>Uma lista de Reservas</returns>
>>>>>>> 15071d622255deff899ace532b96eb6019e1dd24
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

        [HttpPost]
<<<<<<< HEAD
        public IActionResult Post(Reserva NovaReserva)
        {
            try
            {
                _reservaRepository.Cadastrar(NovaReserva);
=======
        public IActionResult CriarReserva(Reserva NovaReserva)
        {
            Produto p = _produtoRepository.BuscarPorId(NovaReserva.IdProduto);
            NovaReserva.IdUsuario = p.IdUsuario;

            _reservaRepository.FazerReserva(NovaReserva);
>>>>>>> 15071d622255deff899ace532b96eb6019e1dd24

                return StatusCode(201);
            }
            catch (Exception Erro)
            {
                return BadRequest(Erro);
            }
        }

<<<<<<< HEAD
        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
=======
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
>>>>>>> 15071d622255deff899ace532b96eb6019e1dd24
        {
            try
            {
                _reservaRepository.Deletar(Id);
                return StatusCode(204);
            }
            catch (Exception Erro)
            {
                return BadRequest(Erro);
            }
        }

        [HttpPut("{Id}")]
        public IActionResult Put(int Id, Reserva ReservaAtualizada)
        {
            try
            {
                _reservaRepository.Atualizar(Id, ReservaAtualizada);
                return StatusCode(204);
            }
            catch (Exception Erro)
            {
                return BadRequest(Erro);
            }
        }
    }
}
