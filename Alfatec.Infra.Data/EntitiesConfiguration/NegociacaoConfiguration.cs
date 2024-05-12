using Alfatec.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alfatec.Infra.Data.EntitiesConfiguration
{
    public class NegociacaoConfiguration : IEntityTypeConfiguration<Negociacao>
    {
        public void Configure(EntityTypeBuilder<Negociacao> builder)
        {
            builder.HasKey(n => n.Id);

            builder.Property(n => n.DataNegociacao)
                .IsRequired();

            builder.Property(n => n.IdEmpresaVendedora)
                .IsRequired();

            builder.Property(n => n.IdEmpresaCompradora)
                .IsRequired();

            builder.Property(n => n.MetodoEnvio)
                .IsRequired();

            builder.Property(n => n.MetodoPagamento)
                .IsRequired();

            builder.Property(n => n.PrevisaoEntrega)
                .IsRequired();

            builder.Property(n => n.StatusPagamento)
                .IsRequired();

            builder.Property(n => n.TipoObjeto)
                .HasDefaultValue(11) 
                .IsRequired();
        }

    }
}
