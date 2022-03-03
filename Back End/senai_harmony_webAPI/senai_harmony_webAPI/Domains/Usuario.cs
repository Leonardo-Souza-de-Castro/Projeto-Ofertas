using System;
using System.Collections.Generic;

#nullable disable

namespace senai_harmony_webAPI.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Clientes = new HashSet<Cliente>();
            Enderecos = new HashSet<Endereco>();
            Instituicaos = new HashSet<Instituicao>();
            Produtos = new HashSet<Produto>();
            Reservas = new HashSet<Reserva>();
        }

        public int IdUsuario { get; set; }
        public int? IdTipoUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual TipoUsuario IdTipoUsuarioNavigation { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; }
        public virtual ICollection<Instituicao> Instituicaos { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
