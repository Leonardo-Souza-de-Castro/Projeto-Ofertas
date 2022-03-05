using senai_harmony_webAPI.Controllers;
using senai_harmony_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_harmony_webAPI.Interfaces
{
    interface IInstituicaoRepository
    {
        /// <summary>
        /// Lista todas as instituicoes
        /// </summary>
        /// <returns>Uma lista de instituicoes</returns>
        List<Instituicao> Listar();

        /// <summary>
        /// Cadastra uma nova instituicao
        /// </summary>
        /// <param name="NovaInstituicao">Objeto NovaInstituicao que será cadastrada</param>
        void Cadastrar(Instituicao NovaInstituicao);

        /// <summary>
        /// Atualiza uma instituicao existente
        /// </summary>
        /// <param name="Id">Id da instituicao que será atualizada</param>
        /// <param name="InstituicaosAtualizada">Objeto com as novas informações</param>
        void Atualizar(int Id, Instituicao InstituicaosAtualizada);

        /// <summary>
        /// Deleta uma instituicao existente
        /// </summary>
        /// <param name="Id">ID da instituicao que será deletada</param>
        void Deletar(int Id);

        /// <summary>
        /// Busca uma instituicao através do ID
        /// </summary>
        /// <param name="Id">ID da instituicao que será buscada</param>
        /// <returns>Uma instituicao buscada</returns>
        Instituicao BuscarPorId(int Id);
    }
}
