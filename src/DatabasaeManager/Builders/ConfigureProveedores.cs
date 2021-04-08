using DatabasaeManager.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatabasaeManager.Builders
{
    public class ConfigureProveedores : IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasIndex(p => p.ApodoProveedor)
                .IsUnique();
        }
    }
}
