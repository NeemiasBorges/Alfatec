using Alfatec.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Alfatec.Infra.Data.EntitiesConfiguration
{
    public class ModoEnvioConfiguration : IEntityTypeConfiguration<ModoEnvio>
    {
        public void Configure(EntityTypeBuilder<ModoEnvio> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Id)
                .IsRequired();

            builder.Property(m => m.NomeTransportadora)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(m => m.CNPJTransportadora)
                .IsRequired()
                .HasMaxLength(14);

            builder.Property(m => m.IETransportadora)
                .IsRequired()
                .HasMaxLength(12);

            builder.Property(m => m.CalculoPrevisaoEntrega)
                .IsRequired();

            builder.Property(m => m.TipoEnvio)
                .IsRequired();

            builder.Property(m => m.TipoObjeto)
                .HasDefaultValue(12) // Valor padrão é 12
                .IsRequired();
        }
    }

}
