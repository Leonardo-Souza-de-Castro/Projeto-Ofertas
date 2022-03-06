using senai_harmony_webAPI.Context;
using senai_harmony_webAPI.Domains;
using senai_harmony_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_harmony_webAPI.Repositories
{
    public class EnderecoRepository : IEnderecoRepository
    {
        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF Core
        /// </summary>
        OFERTAContext ctx = new OFERTAContext();

        /// <summary>
        /// Cadastra um novo Endereco
        /// </summary>
        /// <param name="NovoEndereco">Objeto NovoEndereco que será cadastrado</param>
        public void Cadastrar(Endereco NovoEndereco)
        {
            ctx.Enderecos.Add(NovoEndereco);
            ctx.SaveChanges();
        }

        /// <summary>
        /// Lista todos os Enderecos
        /// </summary>
        /// <returns>Uma lista de instituicoes</returns>
        public List<Endereco> Listar()
        {
            return ctx.Enderecos.ToList();
        }
    }
}
