using System;
using System.Collections.Generic;

#nullable disable

namespace senai_harmony_webAPI.Domains
{
    public partial class Endereco
    {
        public int IdEndereco { get; set; }
        public int? IdUsuario { get; set; }
        public string Logadouro { get; set; }
        public short Numero { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
