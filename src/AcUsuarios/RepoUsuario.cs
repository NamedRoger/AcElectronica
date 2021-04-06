using DatabasaeManager;
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
            var usuarios = await _context.Usuarios.ToListAsync();
            return usuarios;
        }

        public async Task<Usuario> Get(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null) throw new Exception("No existe el usuario");
            return usuario;
        }

        public async Task Add(Usuario nuevoUsuario)
        {
            var result = await _context.Usuarios.AddAsync(nuevoUsuario);
        }

        public Task Update()
        {
            throw new NotImplementedException();
        }

        public Task Delete()
        {
            throw new NotImplementedException();
        }
    }
}
