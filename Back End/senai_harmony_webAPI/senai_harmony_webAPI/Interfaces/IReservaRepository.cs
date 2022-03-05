﻿using senai_harmony_webAPI.Controllers;
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
        /// Lista todos as reservas
        /// </summary>
        /// <returns>Uma lista de reservas</returns>
        List<Reserva> Listar();

        /// <summary>
        /// Cadastra uma nova reserva
        /// </summary>
        /// <param name="NovaReserva">Objeto NovaReserva que será cadastrado</param>
        void FazerReserva(Reserva NovaReserva);

        /// <summary>
        /// Deleta uma reserva existente
        /// </summary>
        /// <param name="Id">ID da reserva que será deletada</param>
        void Deletar(int Id);

        /// <summary>
        /// Busca uma reserva através do ID
        /// </summary>
        /// <param name="id">ID da reserva que será buscada</param>
        /// <returns>Uma reserva buscado</returns>
        Reserva BuscarPorId(int id);

        /// <summary>
        /// Atualiza uma reserva existente
        /// </summary>
        /// <param name="Id">ID da reserva que será atualizado</param>
        /// <param name="ReservaAtualizada">Objeto com as novas informações</param>
        void Editar(int Id, Reserva ReservaAtualizada);

    }
}
