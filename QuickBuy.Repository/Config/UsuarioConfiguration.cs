using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(x => x.Id);

            //Builder utiliza o padrao Fluent
            builder.Property(x => x.Email).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(50);
        }
    }
}
