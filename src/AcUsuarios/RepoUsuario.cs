﻿using DatabasaeManager;
using DatabasaeManager.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcUsuarios
{
    public class RepoUsuario : IRepoUsuario<Usuario>
    {
        private readonly DataContext _context;

        public RepoUsuario(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Usuario>> GetAll()
        {
            var usuarios = await _context.Usuarios
                .Include(u => u.Aplicaciones)
                .Where(u => u.Activo)
                .ToListAsync();

            return usuarios;
        }

        public async Task<Usuario> Get(int id)
        {
            var usuario = await _context.Usuarios.Include(u => u.Aplicaciones).FirstOrDefaultAsync(u => u.Id == id);
            if (usuario == null) throw new Exception("No existe el usuario");
            return usuario;
        }

        public async Task Add(Usuario nuevoUsuario)
        {
            var result = await _context.Usuarios.AddAsync(nuevoUsuario);
            await _context.SaveChangesAsync();
        }

        public Task Update(int id, Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(int id)
        {
            var usuario = await this.Get(id);
            usuario.Activo = false;
            await this._context.SaveChangesAsync();
        }

        public async Task<bool> HasApplication(int idUsuario,string app)
        {
            var usuario = await this.Get(idUsuario);
            if (usuario.Aplicaciones.Count == 0) return false;
            var has = usuario.Aplicaciones.FirstOrDefault(a => a.Nombre.ToUpper().Trim() == app.ToUpper());
            return has != null;
        }
    }
}
