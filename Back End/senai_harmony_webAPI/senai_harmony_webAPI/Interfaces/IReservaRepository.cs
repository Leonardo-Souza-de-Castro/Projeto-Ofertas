using senai_harmony_webAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_harmony_webAPI.Interfaces
{
    interface IReservaRepository
    {

        /// <summary>
        /// Lista todos as reservas
        /// </summary>
        /// <returns>Uma lista de reservas</returns>
        List<ReservaController> Listar();

        /// <summary>
        /// Cadastra uma nova reserva
        /// </summary>
        /// <param name="NovaReserva">Objeto NovaReserva que será cadastrado</param>
        void RealizarReserva(ReservaController NovaReserva);

        /// <summary>
        /// Atualiza uma reserva existente
        /// </summary>
        /// <param name="id">ID da reserva que será atualizado</param>
        /// <param name="ReservaAtualizado">Objeto com as novas informações</param>
        void Editar(int id, ReservaController ReservaAtualizado);

        /// <summary>
        /// Deleta uma reserva existente
        /// </summary>
        /// <param name="id">ID da reserva que será deletada</param>
        void Deletar(int id);

        /// <summary>
        /// Busca uma reserva através do ID
        /// </summary>
        /// <param name="id">ID da reserva que será buscada</param>
        /// <returns>Uma reserva buscado</returns>
        ReservaController BuscarPorId(int id);

    }
}
