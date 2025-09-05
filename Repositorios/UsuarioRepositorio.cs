using Microsoft.EntityFrameworkCore;
using GerenciamentoAtividadesApi.Data;
using GerenciamentoAtividadesApi.Models;
using GerenciamentoAtividadesApi.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GerenciamentoAtividadesApi.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly AppDbContext _dbContext;

        public UsuarioRepositorio(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Usuario>> BuscarTodosUsuarios()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }

        public async Task<Usuario> BuscarPorId(int id)
        {
            return await _dbContext.Usuarios.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<Usuario> Adicionar(Usuario usuario)
        {
            await _dbContext.Usuarios.AddAsync(usuario);
            await _dbContext.SaveChangesAsync();
            return usuario;
        }

        public async Task<Usuario> Atualizar(Usuario usuario, int id)
        {
            var usuarioPorId = await BuscarPorId(id);
            if (usuarioPorId == null)
                throw new Exception($"Usuário com ID {id} não encontrado.");

            usuarioPorId.Nome = usuario.Nome;
            usuarioPorId.Email = usuario.Email;

            _dbContext.Usuarios.Update(usuarioPorId);
            await _dbContext.SaveChangesAsync();
            return usuarioPorId;
        }

        public async Task<bool> Apagar(int id)
        {
            var usuarioPorId = await BuscarPorId(id);
            if (usuarioPorId == null)
                throw new Exception($"Usuário com ID {id} não encontrado.");

            _dbContext.Usuarios.Remove(usuarioPorId);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
