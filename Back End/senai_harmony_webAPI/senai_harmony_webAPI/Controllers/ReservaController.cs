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
    public class ReservaController : ControllerBase
    {

        /// <summary>
        /// Objeto que irá receber todos os métodos da interface
        /// </summary>
        private IReservaRepository _ReservaRepository { get; set; }

        /// <summary>
        /// Instancia o objeto para que haja referência às implementações no repositório
        /// </summary>
        public ReservaController()
        {
            _ReservaRepository = new ReservaRepository();
        }


        /// <summary>
        /// Lista todas as Reservas existentes
        /// </summary>
        /// <returns>Uma lista de Reservas</returns>
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_ReservaRepository.Listar());
        }


        /// <summary>
        /// Busca um usuário através do ID
        /// </summary>
        /// <param name="IdReserva">ID da Reserva que será buscado</param>
        /// <returns>Um usuário buscado e um status code 200 - Ok</returns>
        [HttpGet("IdReserva")]
        public IActionResult BuscarpPorId(int IdReserva)
        {
            Reserva ReservaBusca = _ReservaRepository.BuscarPorId(IdReserva);

            if (ReservaBusca == null)
            {
                return NotFound("A Reserva informada não existe no sistema!");
            }
            return Ok(ReservaBusca);
        }


        /// <summary>
        /// Cadastra uma Reserva
        /// </summary>
        /// <param name="NovaReserva">Reserva a ser cadastrada</param>
        /// <returns>Um status code 201 - Created</returns>
        [HttpPost]
        public IActionResult RealizarReserva(Reserva NovaReserva)
        {
            _ReservaRepository.RealizarReserva(NovaReserva);

            return StatusCode(201);
        }


        /// <summary>
        /// Deleta um Reserva
        /// </summary>
        /// <param name="idReserva">id do Usuário a ser deletado</param>
        /// <returns>Um status code 204 - No content</returns>
        [HttpDelete("IdReserva")]
        public IActionResult Deletar(int idReserva)
        {
            _ReservaRepository.Deletar(idReserva);

            return StatusCode(204);
        }
    }
}
