using senai_harmony_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_harmony_webAPI.Interfaces
{
    interface IEnderecoRepository
    {
        /// <summary>
        /// Cadastra um novo endereco
        /// </summary>
        /// <param name="NovoEndereco">Objeto NovoEndereco que será cadastrado</param>
        void Cadastrar(Endereco NovoEndereco);

        /// <summary>
        /// Lista todos os enderecos
        /// </summary>
        /// <returns>Uma lista de enderecos</returns>
        List<Endereco> Listar();
    }
}
