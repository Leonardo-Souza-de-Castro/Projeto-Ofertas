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

        public Reserva BuscarPorId(int id)
        {
            return ctx.Reservas.FirstOrDefault(p => p.IdReserva == id);
        }

        public void FazerReserva(Reserva novaReserva)
        {
            ctx.Reservas.Add(novaReserva);
            ctx.SaveChanges();
        }


        public void Editar(int id, Reserva ReservaAtualizado)
        {
            Reserva ReservaBuscado = BuscarPorId(id);

            if (ReservaAtualizado.IdSituacaoReserva != null)
            {
                ReservaAtualizado.IdSituacaoReserva = ReservaAtualizado.IdSituacaoReserva;
            }

            ctx.Reservas.Update(ReservaBuscado);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Reserva reservasBuscado = BuscarPorId(id);

            ctx.Reservas.Remove(reservasBuscado);

            ctx.SaveChanges();
        }

        public List<Reserva> Listar()
        {
            return ctx.Reservas.ToList();


        }
    }
}