using System;
using System.Collections.Generic;

#nullable disable

namespace senai_harmony_webAPI.Domains
{
    public partial class TipoProduto
    {
        public TipoProduto()
        {
            Produtos = new HashSet<Produto>();
        }

        public int IdTipoProduto { get; set; }
        public string TipoProduto1 { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
