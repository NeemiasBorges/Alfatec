using Alfatec.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Alfatec.Infra.Data.EntitiesConfiguration
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .IsRequired();

            builder.Property(p => p.NomeProduto)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.DescricaoProduto)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Status)
                .IsRequired();

            builder.Property(p => p.IDCategoria)
                .IsRequired();

            builder.HasOne(p => p.Categoria)
                .WithMany()
                .HasForeignKey(p => p.IDCategoria)
                .IsRequired();

            builder.Property(p => p.UnidadeVenda)
                .IsRequired();

            builder.Property(p => p.IdMidiaProdutos)
                .IsRequired();

            builder.Property(p => p.Variacao);

            builder.Property(p => p.Validade);

            builder.Property(p => p.Classificacao)
                .IsRequired();

            builder.Property(p => p.DataCriacao)
                .IsRequired();

            builder.Property(p => p.TipoObjeto)
                .HasDefaultValue(4) // Valor padrão é 4
                .IsRequired();

            builder.HasMany(p => p.Selos)
                .WithMany()
                .UsingEntity(j => j.ToTable("ProdutoSelos"));

            builder.HasMany(p => p.Comentarios)
                .WithOne(c => c.Produto)
                .HasForeignKey(c => c.IdProduto);

            builder.HasMany(p => p.MidiaProdutos)
                .WithOne(mp => mp.Produto)
                .HasForeignKey(mp => mp.IDproduto);

        }
    }

}
