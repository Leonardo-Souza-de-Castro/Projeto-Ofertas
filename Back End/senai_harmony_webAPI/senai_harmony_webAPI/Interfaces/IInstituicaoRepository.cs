using senai_harmony_webAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_harmony_webAPI.Interfaces
{
    interface IInstituicaoRepository
    {
        /// <summary>
        /// Lista todos as empresas
        /// </summary>
        /// <returns>Uma lista de empresas</returns>
        List<Instituicao> Listar();

        /// <summary>
        /// Cadastra uma nova empresa
        /// </summary>
        /// <param name="novaEmpresa">Objeto novaEmpresa que será cadastrado</param>
        void Cadastrar(Instituicao novaEmpresa);

        /// <summary>
        /// Atualiza uma empresa existente
        /// </summary>
        /// <param name="id">ID da empresa que será atualizado</param>
        /// <param name="empresaAtualizado">Objeto com as novas informações</param>
        void Atualizar(int id, Instituicao empresaAtualizado);

        /// <summary>
        /// Deleta um empresa existente
        /// </summary>
        /// <param name="id">ID da empresa que será deletada</param>
        void Deletar(int id);

        /// <summary>
        /// Busca um empresa através do ID
        /// </summary>
        /// <param name="id">ID da empresa que será buscada</param>
        /// <returns>Uma empresa buscada</returns>
        Instituicao BuscarPorId(int id);
    }
}
