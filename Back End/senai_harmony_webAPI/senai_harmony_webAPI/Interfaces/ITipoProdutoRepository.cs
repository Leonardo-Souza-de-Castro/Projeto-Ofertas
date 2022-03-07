using senai_harmony_webAPI.Domains;
using System.Collections.Generic;

namespace senai_harmony_webAPI.Interfaces
{
    public interface ITipoProdutoRepository
    {
        public List<TipoProduto> Listar();
    }
}
