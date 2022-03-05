using Microsoft.EntityFrameworkCore;
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
    public class ReservaRepository : IReservaRepository
    {
        OFERTAContext ctx = new OFERTAContext();

        /// <summary>
        /// Atualiza uma reserva existente
        /// </summary>
        /// <param name="Id">ID da reserva que será atualizada</param>
        /// <param name="ReservaAtualizada">Objeto com as novas informações</param>
        public void Atualizar(int Id, Reserva ReservaAtualizada)
        {
            Reserva ReservaBuscada = ctx.Reservas.Find(Id);

            if (ReservaAtualizada.QuantidadeReservada > 0)
            {
                ReservaBuscada.QuantidadeReservada = ReservaAtualizada.QuantidadeReservada;
            }

            ctx.Reservas.Update(ReservaBuscada);

            ctx.SaveChanges(); ;
        }

        /// <summary>
        /// Busca uma reserva através do ID
        /// </summary>
        /// <param name="Id">ID da reserva que será buscada</param>
        /// <returns>Uma reserva buscada</returns>
        public Reserva BuscarPorId(int Id)
        {
            return ctx.Reservas.FirstOrDefault(r => r.IdReserva == Id);
        }

        /// <summary>
        /// Cadastra uma nova reserva
        /// </summary>
        /// <param name="NovaReserva">Objeto NovaReserva que será cadastrada</param>
        public void Cadastrar(Reserva NovaReserva)
        {
            ctx.Reservas.Add(NovaReserva);
            ctx.SaveChanges();
        }

        /// <summary>
        /// Deleta uma reserva existente
        /// </summary>
        /// <param name="Id">ID da reserva que será deletada</param>
        public void Deletar(int Id)
        {
            ctx.Reservas.Remove(BuscarPorId(Id));
            ctx.SaveChanges();
        }

        /// <summary>
        /// Lista todas as reservas
        /// </summary>
        /// <returns>Uma lista de Reservas</returns>
        public List<Reserva> Listar()
        {
            return ctx.Reservas.ToList();
        }
    }
}
