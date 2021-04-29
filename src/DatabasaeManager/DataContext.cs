using DatabasaeManager.Builders;
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
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<CategoriaMenu> CategoriaMenus { get; set; }
        public DbSet<CategoriaOpcion> CategoriaOpcions { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ConfigureProveedores());
            modelBuilder.ApplyConfiguration(new ConfifuracionOpcionMenu());
            modelBuilder.ApplyConfiguration(new ConfigurationCategoriasMenu());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=ac_electronica;user=root;password=");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
