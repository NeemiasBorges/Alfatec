using Alfatec.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Alfatec.Infra.Data.EntitiesConfiguration
{
    public class ModoEnvioConfiguration : IEntityTypeConfiguration<ModoEnvio>
    {
        public void Configure(EntityTypeBuilder<ModoEnvio> builder)
        {
            builder.HasKey(me => me.Id);

            builder.Property(me => me.NomeTransportadora)
                .IsRequired();

            builder.Property(me => me.CNPJTransportadora)
                .IsRequired();

            builder.Property(me => me.IETransportadora)
                .IsRequired();

            builder.Property(me => me.CalculoPrevisaoEntrega)
                .IsRequired();

            builder.Property(me => me.TipoEnvio)
                .IsRequired();

            builder.Property(me => me.TipoObjeto)
                .HasDefaultValue(12) 
                .IsRequired();
        }
    }
}
