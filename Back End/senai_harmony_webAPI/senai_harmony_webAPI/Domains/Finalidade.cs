using System;
using System.Collections.Generic;

#nullable disable

namespace senai_harmony_webAPI.Domains
{
    public partial class Finalidade
    {
        public Finalidade()
        {
            Produtos = new HashSet<Produto>();
        }

        public int IdFinalidade { get; set; }
        public string Finalidade1 { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
