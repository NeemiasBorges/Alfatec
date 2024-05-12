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

            builder.Property(p => p.NomeProduto)
                .IsRequired();

            builder.Property(p => p.DescricaoProduto)
                .IsRequired();

            builder.Property(p => p.Status)
                .IsRequired()
                .HasMaxLength(1);

            builder.Property(p => p.Categoria)
                .IsRequired();

            builder.Property(p => p.UnidadeVenda)
                .IsRequired()
                .HasMaxLength(25);

            builder.Property(p => p.IdFotos)
                .IsRequired();

            builder.Property(p => p.Variacao);

            builder.Property(p => p.DataCriacao)
                .IsRequired();

            builder.Property(p => p.Validade);

            builder.Property(p => p.Selos);

            builder.Property(p => p.Classificacao);

            builder.Property(p => p.Comentarios);

            builder.Property(p => p.ComentariosAdicionais);

            builder.Property(p => p.TipoObjeto)
                .HasDefaultValue(4) 
                .IsRequired();

            builder.Property(p => p.IdMidiaProduto);
        }
    }
}
