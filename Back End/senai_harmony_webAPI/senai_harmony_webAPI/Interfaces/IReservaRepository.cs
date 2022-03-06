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
        /// <returns>Uma Lista de Reservas</returns>
        List<Reserva> Listar();

        /// <summary>
        /// Cadastra uma nova Reserva
        /// </summary>
        /// <param name="NovaReserva">Objeto NovaReserva que será cadastrada</param>
        void Cadastrar(Reserva NovaReserva);

        /// <summary>
<<<<<<< HEAD
        /// Atualiza uma Reserva existente
        /// </summary>
        /// <param name="Id">Id da Reserva que será atualizada</param>
        /// <param name="ReservaAtualizada">Objeto com as novas informações</param>
        void Atualizar(int Id, Reserva ReservaAtualizada);

        /// <summary>
        /// Deleta uma Reserva existente
=======
        /// Deleta uma reserva existente
>>>>>>> 15071d622255deff899ace532b96eb6019e1dd24
        /// </summary>
        /// <param name="Id">ID da Reserva que será deletada</param>
        void Deletar(int Id);

        /// <summary>
        /// Busca uma Reserva através do ID
        /// </summary>
<<<<<<< HEAD
        /// <param name="Id">ID da Reserva que será buscada</param>
        /// <returns>Uma Reserva buscada</returns>
        Reserva BuscarPorId(int Id);
=======
        /// <param name="id">ID da reserva que será buscada</param>
        /// <returns>Uma reserva buscado</returns>
        Reserva BuscarPorId(int id);

        /// <summary>
        /// Atualiza uma reserva existente
        /// </summary>
        /// <param name="Id">ID da reserva que será atualizado</param>
        /// <param name="ReservaAtualizada">Objeto com as novas informações</param>
        void Editar(int Id, Reserva ReservaAtualizada);
>>>>>>> 15071d622255deff899ace532b96eb6019e1dd24

    }
}
