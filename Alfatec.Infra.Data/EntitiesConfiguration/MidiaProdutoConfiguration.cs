using Alfatec.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alfatec.Infra.Data.EntitiesConfiguration
{

    public class MidiaProdutoConfiguration : IEntityTypeConfiguration<MidiaProduto>
    {
        public void Configure(EntityTypeBuilder<MidiaProduto> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Id)
                .IsRequired();

            builder.Property(m => m.IDproduto)
                .IsRequired();

            builder.HasOne(m => m.Produto)
                .WithMany(p => p.Midias)
                .HasForeignKey(m => m.IDProduto)
                .IsRequired();

            builder.Property(m => m.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(m => m.TipoArquivo)
                .IsRequired();

            builder.Property(m => m.Diretorio)
                .IsRequired();

            builder.Property(m => m.TipoObjeto)
                .HasDefaultValue(9) // Valor padrão é 9
                .IsRequired();

        }
    }
}

