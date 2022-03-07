using senai_harmony_webAPI.Context;
using senai_harmony_webAPI.Domains;
using senai_harmony_webAPI.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace senai_harmony_webAPI.Repositories
{
    public class TipoProdutoRepository : ITipoProdutoRepository
    {
        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF Core
        /// </summary>
        OFERTAContext ctx = new OFERTAContext();

        /// <summary>
        /// Lista todos os Enderecos
        /// </summary>
        /// <returns>Uma lista de instituicoes</returns>
        public List<TipoProduto> Listar()
        {
            return ctx.TipoProdutos.ToList();
        }
    }
}
