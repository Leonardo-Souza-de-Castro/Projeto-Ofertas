using System;
using System.Collections.Generic;

#nullable disable

namespace senai_harmony_webAPI.Domains
{
    public partial class Produto
    {
        public Produto()
        {
            Reservas = new HashSet<Reserva>();
        }

        public int IdProduto { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdTipoProduto { get; set; }
        public int? IdFinalidade { get; set; }
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public short Quantidade { get; set; }
        public double Preco { get; set; }
        public DateTime DataValidade { get; set; }
        public string Imagem { get; set; }

        public virtual Finalidade IdFinalidadeNavigation { get; set; }
        public virtual TipoProduto IdTipoProdutoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
