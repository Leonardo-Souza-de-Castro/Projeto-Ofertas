using senai_harmony_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_harmony_webAPI.Interfaces
{
    interface IProdutoRepository
    {
        /// <summary>
        /// Lista todos os produtos
        /// </summary>
        /// <returns>Uma lista de produtos</returns>
        List<Produto> Listar();

        /// <summary>
        /// Lista todos os produtos da empresa
        /// </summary>
        /// <returns>Uma lista de produtos</returns>
        List<Produto> ListarInstituicao(int IdInstituicao);

        /// <summary>
        /// Lista todos os produtos da determinada categoria
        /// </summary>
        /// <returns>Uma lista de produtos</returns>
        List<Produto> ListarCategoria(int IdCategoria);

        /// <summary>
        /// Cadastra um novo produto
        /// </summary>
        /// <param name="NovoProduto">Objeto novoProduto que será cadastrado</param>
        void Cadastrar(Produto NovoProduto);

        /// <summary>
        /// Atualiza um produto existente
        /// </summary>
        /// <param name="Id">ID do produto que será atualizado</param>
        /// <param name="ProdutoAtualizado">Objeto com as novas informações</param>
        void Atualizar(int Id, Produto ProdutoAtualizado);

        /// <summary>
        /// Deleta um produto existente
        /// </summary>
        /// <param name="Id">ID do produto que será deletado</param>
        void Deletar(int Id);

        /// <summary>
        /// Busca um produto através do ID
        /// </summary>
        /// <param name="Id">ID do produto que será buscado</param>
        /// <returns>Um produto buscado</returns>
        Produto BuscarPorId(int Id);
        Produto BuscarPorId(int? idProduto);
    }
}
