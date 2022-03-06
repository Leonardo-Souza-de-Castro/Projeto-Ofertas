using System;
using System.Collections.Generic;

#nullable disable

namespace senai_harmony_webAPI.Domains
{
    public partial class Reserva
    {
        public int IdReserva { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdSituacaoReserva { get; set; }
        public int? IdProduto { get; set; }
        public short QuantidadeReservada { get; set; }

        public virtual Produto IdProdutoNavigation { get; set; }
        public virtual SituacaoReserva IdSituacaoReservaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
