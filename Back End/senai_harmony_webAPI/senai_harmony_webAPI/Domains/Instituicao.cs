using System;
using System.Collections.Generic;

#nullable disable

namespace senai_harmony_webAPI.Domains
{
    public partial class Instituicao
    {
        public int IdInstituicao { get; set; }
        public int? IdUsuario { get; set; }
        public string Cnpj { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
