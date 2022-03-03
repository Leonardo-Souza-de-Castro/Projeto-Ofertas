using senai_harmony_webAPI.Domains;
using senai_harmony_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_harmony_webAPI.Repositories
{
    public class ProdutoRepository : IProdutosRepository
    {
        public void Atualizar(int id, Produto produtoAtualizado)
        {
            throw new NotImplementedException();
        }

        public Produto BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Produto novoProduto)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Produto> Listar()
        {
            throw new NotImplementedException();
        }

        public List<Produto> ListarCategoria(int idCategoria)
        {
            throw new NotImplementedException();
        }

        public List<Produto> ListarInstituicao(int idInstituicao)
        {
            throw new NotImplementedException();
        }
    }
}
