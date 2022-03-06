using senai_harmony_webAPI.Controllers;
using senai_harmony_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_harmony_webAPI.Interfaces
{
    interface IReservaRepository
    {

        /// <summary>
        /// Lista todas as Reservas
        /// </summary>
        /// <returns>Uma lista de Reservas</returns>
        List<Reserva> Listar();

        /// <summary>
        /// Cadastra uma nova Reservas
        /// </summary>
        /// <param name="NovaReserva">Objeto NovaReservas que será cadastrada</param>
        void Cadastrar(Reserva NovaReserva);

        /// <summary>
        /// Atualiza uma Reserva existente
        /// </summary>
        /// <param name="Id">Id da Reserva que será atualizada</param>
        /// <param name="ReservaAtualizada">Objeto com as novas informações</param>
        void Atualizar(int Id, Reserva ReservaAtualizada);

        /// <summary>
        /// Deleta uma Reserva existente
        /// </summary>
        /// <param name="Id">ID da Reserva que será deletada</param>
        void Deletar(int Id);

        /// <summary>
        /// Busca uma Reserva através do ID
        /// </summary>
        /// <param name="Id">ID da Reserva que será buscada</param>
        /// <returns>Uma instituicao buscada</returns>
        Reserva BuscarPorId(int Id);

    }
}
