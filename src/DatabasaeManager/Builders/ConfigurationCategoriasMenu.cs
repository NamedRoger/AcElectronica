using DatabasaeManager.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatabasaeManager.Builders
{
    public class ConfigurationCategoriasMenu : IEntityTypeConfiguration<CategoriaMenu>
    {
        public void Configure(EntityTypeBuilder<CategoriaMenu> builder)
        {
            builder.HasKey(c => c.IdCategoriaMenu);

        }
    }
}
