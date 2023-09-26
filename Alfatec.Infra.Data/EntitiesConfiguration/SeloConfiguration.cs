using Alfatec.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Alfatec.Infra.Data.EntitiesConfiguration
{
    public class SeloConfiguration : IEntityTypeConfiguration<Selo>
    {
        public void Configure(EntityTypeBuilder<Selo> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id)
                .IsRequired();

            builder.Property(s => s.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(s => s.DataCriacao)
                .IsRequired();

            builder.Property(s => s.TipoObjeto)
                .HasDefaultValue(7) // Valor padrão é 7
                .IsRequired();
        }
    }

}
