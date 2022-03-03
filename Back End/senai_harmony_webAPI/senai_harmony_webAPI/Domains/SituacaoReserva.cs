using System;
using System.Collections.Generic;

#nullable disable

namespace senai_harmony_webAPI.Domains
{
    public partial class SituacaoReserva
    {
        public SituacaoReserva()
        {
            Reservas = new HashSet<Reserva>();
        }

        public int IdSituacaoReserva { get; set; }
        public string SituacaoReserva1 { get; set; }

        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
