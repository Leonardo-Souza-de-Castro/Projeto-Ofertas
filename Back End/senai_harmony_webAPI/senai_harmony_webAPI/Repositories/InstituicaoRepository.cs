using senai_harmony_webAPI.Context;
using senai_harmony_webAPI.Controllers;
using senai_harmony_webAPI.Domains;
using senai_harmony_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_harmony_webAPI.Repositories
{
    public class InstituicaoRepository : IInstituicaoRepository
    {
        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF Core
        /// </summary>
        OFERTAContext ctx = new OFERTAContext();

        /// <summary>
        /// Atualiza uma instituicao existente
        /// </summary>
        /// <param name="Id">ID da instituicao que será atualizada</param>
        /// <param name="InstituicaoAtualizada">Objeto com as novas informações</param>
        public void Atualizar(int Id, Instituicao InstituicaoAtualizada)
        {
            Instituicao InstituicaoBuscada = ctx.Instituicaos.Find(Id);

            if (InstituicaoAtualizada.Cnpj != null)
            {
                InstituicaoBuscada.Cnpj = InstituicaoAtualizada.Cnpj;
            }

            if (InstituicaoAtualizada.NomeFantasia != null)
            {
                InstituicaoBuscada.NomeFantasia = InstituicaoAtualizada.NomeFantasia;
            }

            if (InstituicaoAtualizada.RazaoSocial != null)
            {
                InstituicaoBuscada.RazaoSocial = InstituicaoAtualizada.RazaoSocial;
            }

            ctx.Instituicaos.Update(InstituicaoBuscada);

            ctx.SaveChanges(); ;
        }

        /// <summary>
        /// Busca uma instituicao através do ID
        /// </summary>
        /// <param name="Id">ID da instituicao que será buscada</param>
        /// <returns>Uma instituicao buscada</returns>
        public Instituicao BuscarPorId(int Id)
        {
            return ctx.Instituicaos.FirstOrDefault(i => i.IdInstituicao == Id);
        }

        /// <summary>
        /// Cadastra uma nova Intituição
        /// </summary>
        /// <param name="NovaInstituicao">Objeto NovaInstituicao que será cadastrada</param>
        public void Cadastrar(Instituicao NovaInstituicao)
        {
            ctx.Instituicaos.Add(NovaInstituicao);
            ctx.SaveChanges();
        }

        /// <summary>
        /// Deleta uma instituicao existente
        /// </summary>
        /// <param name="Id">ID da instituicao que será deletada</param>
        public void Deletar(int Id)
        {
            ctx.Instituicaos.Remove(BuscarPorId(Id));
            ctx.SaveChanges();
        }

        /// <summary>
        /// Lista todas as instituicoes
        /// </summary>
        /// <returns>Uma lista de instituicoes</returns>
        public List<Instituicao> Listar()
        {
            return ctx.Instituicaos.ToList();
        }

    }
}
