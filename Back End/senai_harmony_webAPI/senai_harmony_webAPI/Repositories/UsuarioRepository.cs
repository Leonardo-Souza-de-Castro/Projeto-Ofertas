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

        public void Atualizar(int Id, Usuario UsuarioAtualizado)
        {
            Usuario UsuarioBuscado = ctx.Usuarios.Find(Id);

            if (UsuarioAtualizado.Email != null)
            {
                UsuarioBuscado.Email = UsuarioAtualizado.Email;
            }

            if (UsuarioAtualizado.Senha != null)
            {
                UsuarioBuscado.Senha = UsuarioAtualizado.Senha;
            }

            ctx.Usuarios.Update(UsuarioBuscado);

            ctx.SaveChanges();
        }


        public Usuario BuscarPorId(int Id)
        {
            return ctx.Usuarios.FirstOrDefault(p => p.IdUsuario == Id);
        }

        public void Cadastrar(Usuario NovoUsuario)
        {
            // Adiciona este novoUsuario
            ctx.Usuarios.Add(NovoUsuario);

            // Salva as informações para serem gravadas no banco de dados
            ctx.Usuarios.Add(NovoUsuario);
            ctx.SaveChanges();
        }


        public void Deletar(int Id)
        {
            Usuario UsuarioBuscado = BuscarPorId(Id);

            ctx.Usuarios.Remove(UsuarioBuscado);

            ctx.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            return ctx.Usuarios.Include(C => C.IdTipoUsuarioNavigation).ToList();
        }

        public Usuario Login(string Email, string Senha)
        {
            return ctx.Usuarios.FirstOrDefault(u => u.Email == Email && u.Senha == Senha);
        }
    }
}
