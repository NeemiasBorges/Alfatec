using Alfatec.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Alfatec.Infra.Data.EntitiesConfiguration
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.NomeCategoria)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.DataCriacao)
                .IsRequired();

            builder.Property(c => c.TipoObjeto)
                .HasDefaultValue(7)
                .IsRequired();

            builder.HasData(
                new Categoria { Id = 1, NomeCategoria = "Grãos e cereais", DataCriacao = DateTime.Now, TipoObjeto = 7 },
                new Categoria { Id = 2, NomeCategoria = "Frutas", DataCriacao = DateTime.Now, TipoObjeto = 7 },
                new Categoria { Id = 3, NomeCategoria = "Horaliças", DataCriacao = DateTime.Now, TipoObjeto = 7 },
                new Categoria { Id = 4, NomeCategoria = "Produtos lácteos", DataCriacao = DateTime.Now, TipoObjeto = 7 },
                new Categoria { Id = 5, NomeCategoria = "Carne e aves", DataCriacao = DateTime.Now, TipoObjeto = 7 }
            );
        }
    }
}
