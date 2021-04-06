using DatabasaeManager.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics.CodeAnalysis;

namespace DatabasaeManager
{
    public class DataContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Aplicacion> Aplicaciones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=ac_electronica;user=root;password=root");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
