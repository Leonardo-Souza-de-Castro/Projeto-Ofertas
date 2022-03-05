using System;
using System.Collections.Generic;

#nullable disable

namespace senai_harmony_webAPI.Domains
{
    public partial class Cliente
    {
        public int IdCliente { get; set; }
        public int? IdUsuario { get; set; }
        public string NomeCliente { get; set; }
        public string Cpf { get; set; }
        public string Nis { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }

    }
}
