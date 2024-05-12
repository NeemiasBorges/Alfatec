using Alfatec.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alfatec.Infra.Data.EntitiesConfiguration
{

    public class MidiaProdutoConfiguration : IEntityTypeConfiguration<MidiaProduto>
    {
        public void Configure(EntityTypeBuilder<MidiaProduto> builder)
        {
            builder.HasKey(mp => mp.Id);

            builder.Property(mp => mp.Nome)
                .IsRequired();

            builder.Property(mp => mp.TipoArquivo)
                .IsRequired();

            builder.Property(mp => mp.Diretorio)
                .IsRequired();

            builder.Property(mp => mp.TipoObjeto)
                .HasDefaultValue(9) // Valor padrão é 9
                .IsRequired();

            builder.HasOne(mp => mp.Produto)
                .WithMany() 
                .HasForeignKey(mp => mp.IDproduto)
                .IsRequired();
        }
    }
}

