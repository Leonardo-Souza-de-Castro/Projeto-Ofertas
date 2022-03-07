using Microsoft.AspNetCore.Mvc;
using senai_harmony_webAPI.Domains;
using senai_harmony_webAPI.Interfaces;
using senai_harmony_webAPI.Repositories;
using senai_harmony_webAPI.Utils;
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
        /// <param name="Id">ID do usuário que será buscado</param>
        /// <returns>Um usuário buscado e um status code 200 - Ok</returns>
        [HttpGet("Id")]
        public IActionResult BuscarpPorId(int Id)
        {
            Usuario UsuarioBuscado = _usuarioRepository.BuscarPorId(Id);

            if (UsuarioBuscado == null)
            {
                return NotFound("O Usuário informado não existe no sistema!");
            }
            return Ok(UsuarioBuscado);
        }

        /// <summary>
        /// Cadastra um Usuário
        /// </summary>
        /// <param name="NovoUsuario">Usuario a ser cadastrado</param>
        /// <returns>Um status code 201 - Created</returns>
        [HttpPost]
        public IActionResult Cadastrar(Usuario NovoUsuario)
        {

            //fazer erificacao se ja tem o msm email cadastrado
            _usuarioRepository.Cadastrar(NovoUsuario);

            return Ok(NovoUsuario.IdUsuario);

        }

        /// <summary>
        /// Atualiza um usuário existente
        /// </summary>
        /// <param name="Id">ID do usuário que será atualizado</param>
        /// <param name="UsuarioAtualizado">Objeto com as novas informações</param>
        /// <returns>Um status code 204 - No Content</returns>
        [HttpPut("Id")]
        public IActionResult Put(int Id, Usuario UsuarioAtualizado)
        {
            try
            {
                // Faz a chamada para o método
                _usuarioRepository.Atualizar(Id, UsuarioAtualizado);

                // Retorna um status code
                return StatusCode(204);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Deleta um usuário existente
        /// </summary>
        /// <param name="IdUsuario">ID do usuário que será deletado</param>
        /// <returns>Um status code 204 - No Content</returns>
        [HttpDelete("{IdUsuario}")]
        public IActionResult Delete(int IdUsuario)
        {
            _usuarioRepository.Deletar(IdUsuario);

            return StatusCode(204);
        }
    }
}
