using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using senai_harmony_webAPI.Context;
using senai_harmony_webAPI.Domains;
using senai_harmony_webAPI.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace senai_harmony_webAPI.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
         
        OFERTAContext ctx = new OFERTAContext();

        public void Atualizar(int id, Usuario UsuarioAtualizado)
        {
            // Busca um usuário através do id
            Usuario usuarioBuscado = ctx.Usuarios.Find(id);

            // Verifica se o e-mail do usuário foi informado
            if (UsuarioAtualizado.Email != null)
            {
                // Atribui os novos valores ao campos existentes
                usuarioBuscado.Email = UsuarioAtualizado.Email;
            }

            // Verifica se a senha do usuário foi informado
            if (UsuarioAtualizado.Senha != null)
            {
                // Atribui os novos valores ao campos existentes
                usuarioBuscado.Senha = UsuarioAtualizado.Senha;
            }

            // Atualiza o tipo de usuário que foi buscado
            ctx.Usuarios.Update(usuarioBuscado);

            // Salva as informações para serem gravadas no banco
            ctx.SaveChanges();
        }


        public Usuario BuscarPorId(int id)
        {
            return ctx.Usuarios.FirstOrDefault(p => p.IdUsuario == id);
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            // Adiciona este novoUsuario
            ctx.Usuarios.Add(novoUsuario);

            // Salva as informações para serem gravadas no banco de dados
            ctx.Usuarios.Add(novoUsuario);
            ctx.SaveChanges();
        }


        public void Deletar(int id)
        {
            Usuario UsuarioBuscado = BuscarPorId(id);

            ctx.Usuarios.Remove(UsuarioBuscado);

            ctx.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            return ctx.Usuarios.Include(C => C.IdTipoUsuarioNavigation).ToList();
        }

        public Usuario Login(string email, string senha)
        {
            return ctx.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }
    }
}
