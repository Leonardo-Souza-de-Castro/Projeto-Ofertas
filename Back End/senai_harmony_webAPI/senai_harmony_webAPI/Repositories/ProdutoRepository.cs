using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using senai_harmony_webAPI.Context;
using senai_harmony_webAPI.Domains;
using senai_harmony_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace senai_harmony_webAPI.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        OFERTAContext ctx = new OFERTAContext();

        /// <summary>
        /// Atualiza um Produto existente
        /// </summary>
        /// <param name="Id">ID do Produto que será atualizado</param>
        /// <param name="ProdutoAtualizado">Objeto com as novas informações</param>
        public void Atualizar(int Id, Produto ProdutoAtualizado)
        {
            Produto ProdutoBuscado = ctx.Produtos.Find(Id);

            if (ProdutoAtualizado.NomeProduto != null)
            {
                ProdutoBuscado.NomeProduto = ProdutoAtualizado.NomeProduto;
            }

            if (ProdutoAtualizado.Descricao != null)
            {
                ProdutoBuscado.Descricao = ProdutoAtualizado.Descricao;
            }

            if (ProdutoAtualizado.Quantidade != 0)
            {
                ProdutoBuscado.Quantidade = ProdutoAtualizado.Quantidade;
            }

            if (ProdutoAtualizado.Preco != 0)
            {
                ProdutoBuscado.Preco = ProdutoAtualizado.Preco;
            }

            if (ProdutoAtualizado.DataValidade < DateTime.Now)
            {
                ProdutoBuscado.DataValidade = ProdutoAtualizado.DataValidade;
            }

            if (ProdutoAtualizado.Imagem != null)
            {
                ProdutoBuscado.Imagem = ProdutoAtualizado.Imagem;
            }


            ctx.Produtos.Update(ProdutoBuscado);

            ctx.SaveChanges(); 
        }

        /// <summary>
        /// Busca um produto através do ID
        /// </summary>
        /// <param name="Id">ID do produto que será buscado</param>
        /// <returns>Um produto buscado</returns>
        public Produto BuscarPorId(int Id)
        {
            return ctx.Produtos.Include(p => p.IdFinalidadeNavigation).FirstOrDefault(p => p.IdProduto == Id);
        }

        /// <summary>
        /// Cadastra um novo Produto
        /// </summary>
        /// <param name="NovoProduto">Objeto NovoProduto que será cadastrado</param>
        public void Cadastrar(Produto NovoProduto)
        {
            ctx.Produtos.Add(NovoProduto);
            ctx.SaveChanges();
        }

        /// <summary>
        /// Deleta um Produto existente
        /// </summary>
        /// <param name="Id">ID do Produto que será deletado</param>
        public void Deletar(int Id)
        {
            ctx.Produtos.Remove(BuscarPorId(Id));
            ctx.SaveChanges();
        }

        /// <summary>
        /// Lista todos os Produtos
        /// </summary>
        /// <returns>Uma lista de instituicoes</returns>
        public List<Produto> Listar()
        {
            return ctx.Produtos.Include(p => p.IdFinalidadeNavigation).ToList();
        }

        public string ConsultarImagem(int IdProduto)
        {
            CriarPasta();

            string nome_novo = IdProduto.ToString() + ".png";
            string caminho = Path.Combine("Produtos", nome_novo);

            if (File.Exists(caminho))
            {
                byte[] bytesArquivo = File.ReadAllBytes(caminho);
                return Convert.ToBase64String(bytesArquivo);
            }

            return null;
        }

        public void CriarPasta()
        {
            string pasta = "Produtos";

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
        }

        public void SalvarImagem(IFormFile foto, int IdProduto)
        {
            string nome_novo = IdProduto.ToString() + ".png";

            using (var stream = new FileStream(Path.Combine("Perfil", nome_novo), FileMode.Create))
            {
                foto.CopyTo(stream);
            }
        }
    }
}
