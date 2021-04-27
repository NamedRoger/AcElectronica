using DatabasaeManager.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatabasaeManager.Builders
{
    public class ConfifuracionOpcionMenu : IEntityTypeConfiguration<CategoriaOpcion>
    {
        public void Configure(EntityTypeBuilder<CategoriaOpcion> builder)
        {
            builder.HasKey(c => c.IdCategoriaOpcion);

            builder.HasOne(c => c.CategoriaMenu)
                .WithMany(ca => ca.CategoriaOpcions)
                .HasForeignKey(c => c.IdCategoriaMenu);
        }
    }
}
