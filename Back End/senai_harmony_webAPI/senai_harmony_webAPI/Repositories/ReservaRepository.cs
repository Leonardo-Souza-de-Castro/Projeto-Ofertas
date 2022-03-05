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

        public List<Reserva> Listar()
        {
            return ctx.Reservas.ToList();

        }

        public Reserva BuscarPorId(int Id)
        {
            return ctx.Reservas.FirstOrDefault(r => r.IdReserva == Id);
        }

        public void FazerReserva(Reserva NovaReserva)
        {
            throw new NotImplementedException();
        }

        public void AtualizarReserva(int Id, Reserva ReservaAtualizada)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            Reserva ReservaBusca = BuscarPorId(id);

            ctx.Reservas.Remove(ReservaBusca);

            ctx.SaveChanges();
        }

        //public void EditarReserva(int id, Reserva ReservaAtualizado)
        //{
        //    Reserva reservaBuscado = BuscarPorId(id);

        //    if (ReservaAtualizado.IdSituacaoReserva != null)
        //    {
        //        reservaBuscado.IdSituacaoReserva = ReservaAtualizado.IdSituacaoReserva;
        //    }

        //    ctx.Reservas.Update(reservaBuscado);

        //    ctx.SaveChanges();
        //}
    }
}
