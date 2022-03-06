using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace senai_harmony_webAPI.Utils
{
    public class Upload
    {
        /// <summary>
        /// Faz o upload do arquivo para o servidor
        /// </summary>
        /// <param name="Arquivo">Arquivo vindo de um formulário</param>
        /// <param name="ExtensoesPermitidas">Array com extensões permitidas apenas</param>
        /// <returns>Nome do arquivo salvo</returns>
        public static string UploadFile(IFormFile Arquivo, string[] ExtensoesPermitidas)
        {
            try
            {
                var Pasta = Path.Combine("StaticFiles", "Images");
                var Caminho = Path.Combine(Directory.GetCurrentDirectory(), Pasta);

                if (Arquivo.Length > 0)
                {
                    var FileName = ContentDispositionHeaderValue.Parse(Arquivo.ContentDisposition).FileName.Trim('"');

                    if (ValidarExtensao(ExtensoesPermitidas, FileName))
                    {
                        var Extensao = RetornarExtensao(FileName);
                        var NovoNome = $"{Guid.NewGuid()}.{Extensao}";
                        var CaminhoCompleto = Path.Combine(Caminho, NovoNome);

                        using (var Stream = new FileStream(CaminhoCompleto, FileMode.Create))
                        {
                            Arquivo.CopyTo(Stream);
                        }

                        return NovoNome;
                    }

                    return "Extensão não permitida";
                }
                return "";
            }
            catch (Exception Ex)
            {
                return Ex.ToString();
            }
        }

        /// <summary>
        /// Valida o uso de enxtensões permitidas apenas
        /// </summary>
        /// <param name="Extensoes">Array de extensões permitidas</param>
        /// <param name="NomeDoArquivo">Nome do arquivo</param>
        /// <returns>Verdadeiro/Falso</returns>
        public static bool ValidarExtensao(string[] Extensoes, string NomeDoArquivo)
        {
            string[] Dados = NomeDoArquivo.Split(".");
            string Extensao = Dados[Dados.Length - 1];

            foreach (var Item in Extensoes)
            {
                if (Extensao == Item)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Remove um arquivo do servidor
        /// </summary>
        /// <param name="NomeDoArquivo">Nome do Arquivo</param>
        public static void RemoverArquivo(string NomeDoArquivo)
        {
            var Pasta = Path.Combine("StaticFiles", "Images");
            var Caminho = Path.Combine(Directory.GetCurrentDirectory(), Pasta);
            var CaminhoCompleto = Path.Combine(Caminho, NomeDoArquivo);

            File.Delete(CaminhoCompleto);
        }

        /// <summary>
        /// Retorna a extensão de um arquivo
        /// </summary>
        /// <param name="NomeDoArquivo">Nome do Arquivo</param>
        /// <returns>Retorna a extensão de um arquivo</returns>
        public static string RetornarExtensao(string NomeDoArquivo)
        {
            string[] Dados = NomeDoArquivo.Split(".");
            return Dados[Dados.Length - 1];
        }
    }
}
