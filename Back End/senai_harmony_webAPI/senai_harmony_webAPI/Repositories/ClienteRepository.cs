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
    public class ClienteRepository : IClienteRepository
    {

        OFERTAContext ctx = new OFERTAContext();


        public void Atualizar(int id, Cliente ClienteAtualizado)
        {
            // Busca um usuário através do id
            Cliente ClienteBuscado = ctx.Cliente.Find(id);

            if (ClienteAtualizado.IdUsuario != null)
            {
                // Atribui os novos valores ao campos existentes
                ClienteBuscado.IdUsuario = ClienteAtualizado.IdUsuario;
            }

            // Verifica se o e-mail do usuário foi informado
            if (ClienteAtualizado.NomeCliente != null)
            {
                // Atribui os novos valores ao campos existentes
                ClienteBuscado.NomeCliente = ClienteAtualizado.NomeCliente;
            }

            // Verifica se a senha do usuário foi informado
            if (ClienteAtualizado.Cpf != null)
            {
                // Atribui os novos valores ao campos existentes
                ClienteBuscado.Cpf = ClienteAtualizado.Cpf;
            }

            // Verifica se a senha do usuário foi informado
            if (ClienteAtualizado.Nis != null)
            {
                // Atribui os novos valores ao campos existentes
                ClienteBuscado.Nis = ClienteAtualizado.Nis;
            }

            // Atualiza o tipo de usuário que foi buscado
            ctx.Cliente.Update(ClienteBuscado);

            // Salva as informações para serem gravadas no banco
            ctx.SaveChanges();
        }

        public Cliente BuscarPorId(int id)
        {
            return ctx.Cliente.FirstOrDefault(p => p.IdCliente == id);
        }

        public void Cadastrar(Cliente NovoCliente)
        {
            // Adiciona este novoUsuario
            ctx.Cliente.Add(NovoCliente);

            // Salva as informações para serem gravadas no banco de dados
            ctx.Cliente.Add(NovoCliente);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Cliente ClienteBuscado = BuscarPorId(id);

            ctx.Cliente.Remove(ClienteBuscado);

            ctx.SaveChanges();
        }

        public List<Cliente> Listar()
        {
            return ctx.Cliente.ToList();
        }

 
    }
}
