using Microsoft.AspNetCore.Mvc;
using senai_harmony_webAPI.Domains;
using senai_harmony_webAPI.Interfaces;
using senai_harmony_webAPI.Repositories;
using System;

namespace senai_harmony_webAPI.Controllers
{

    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        /// <summary>
        /// Objeto que irá receber todos os métodos da interface
        /// </summary>
        private IUsuarioRepository _usuarioRepository { get; set; }

        /// <summary>
        /// Instancia o objeto para que haja referência às implementações no repositório
        /// </summary>
        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        /// <summary>
        /// Lista todos os Usuários existentes
        /// </summary>
        /// <returns>Uma lista de usuários</returns>
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_usuarioRepository.Listar());
        }

        /// <summary>
        /// Busca um usuário através do ID
        /// </summary>
        /// <param name="IdUsuario">ID do usuário que será buscado</param>
        /// <returns>Um usuário buscado e um status code 200 - Ok</returns>
        [HttpGet("IdUsuario")]
        public IActionResult BuscarpPorId(int IdUsuario)
        {
            Usuario usuarioBuscado = _usuarioRepository.BuscarPorId(IdUsuario);

            if (usuarioBuscado == null)
            {
                return NotFound("O Usuário informado não existe no sistema!");
            }
            return Ok(usuarioBuscado);
        }

        /// <summary>
        /// Cadastra um Usuário
        /// </summary>
        /// <param name="NovoUsuario">Usuario a ser cadastrado</param>
        /// <returns>Um status code 201 - Created</returns>
        [HttpPost]
        public IActionResult Cadastrar(Usuario NovoUsuario)
        {
            _usuarioRepository.Cadastrar(NovoUsuario);

            return StatusCode(201);
        }

        /// <summary>
        /// Atualiza um usuário existente
        /// </summary>
        /// <param name="id">ID do usuário que será atualizado</param>
        /// <param name="usuarioAtualizado">Objeto com as novas informações</param>
        /// <returns>Um status code 204 - No Content</returns>
        [HttpPut("id")]
        public IActionResult Put(int id, Usuario usuarioAtualizado)
        {
            try
            {
                // Faz a chamada para o método
                _usuarioRepository.Atualizar(id, usuarioAtualizado);

                // Retorna um status code
                return StatusCode(204);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        /// <summary>
        /// Deleta um usuário
        /// </summary>
        /// <param name="idUsuario">id do Usuário a ser deletado</param>
        /// <returns>Um status code 204 - No content</returns>
        [HttpDelete("IdUsuario")]
        public IActionResult Deletar(int idUsuario)
        {
            _usuarioRepository.Deletar(idUsuario);

            return StatusCode(204);
        }
    }
}
