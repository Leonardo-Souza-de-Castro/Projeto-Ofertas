using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_harmony_webAPI.Utils
{
    public class Criptografia
    {
        public static string GerarHash(string Senha)
        {
            return BCrypt.Net.BCrypt.HashPassword(Senha);
        }

        public static bool Comparar(string SenhaForm, string SenhaBanco)
        {
            return BCrypt.Net.BCrypt.Verify(SenhaForm, SenhaBanco);
        }
    }
}
