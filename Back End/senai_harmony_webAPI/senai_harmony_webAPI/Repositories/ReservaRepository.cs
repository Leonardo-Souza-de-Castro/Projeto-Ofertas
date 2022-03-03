using senai_harmony_webAPI.Controllers;
using senai_harmony_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_harmony_webAPI.Repositories
{
    public class ReservaRepository : IReservaRepository
    {
        public Reserva BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Criar(Reserva novaReserva)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public void Editar(int id, Reserva reservaAtualizado)
        {
            throw new NotImplementedException();
        }

        public List<Reserva> Listar()
        {
            throw new NotImplementedException();
        }

        public List<Reserva> ListarCliente(int idCliente)
        {
            throw new NotImplementedException();
        }

        public List<Reserva> ListarEmpresa(int idEmpresa)
        {
            throw new NotImplementedException();
        }

        public List<Reserva> ListarPendentes(int idEmpresa)
        {
            throw new NotImplementedException();
        }
    }
}
