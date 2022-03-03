using Microsoft.AspNetCore.Http;
using senai_harmony_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_harmony_webAPI.Interfaces
{
    interface IUsuarioRepository
    {

        // <summary>
        /// Valida o usuário
        /// </summary>
        /// <param name="Email">E-mail do usuário</param>
        /// <param name="Senha">Senha do usuário</param>
        /// <returns>Um objeto do tipo Usuario que foi encontrado</returns>
        Usuario Login(string Email, string Senha);


        //IFormFile Representa um arquivo enviado com o HttpRequest.
        void SalvarPerfilBD(IFormFile foto, int id_usuario);
        void SalvarPerfilDir(IFormFile foto, int id_usuario);
        string ConsultarPerfilBD(int id_usuario);
        string ConsultarPerfilDir(int id_usuario);


        /// <summary>
        /// Lista todos os usuários
        /// </summary>
        /// <returns>Uma lista de usuários</returns>
        List<Usuario> Listar();
    }
}
