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

            builder.Property(n => n.Id)
                .IsRequired();

            builder.Property(n => n.Data)
                .IsRequired();

            builder.Property(n => n.IDEmpresaVendedora)
                .IsRequired();

            builder.HasOne(n => n.EmpresaVendedora)
                .WithMany()
                .HasForeignKey(n => n.IDEmpresaVendedora)
                .IsRequired();

            builder.Property(n => n.IDEmpresaCompradora)
                .IsRequired();

            builder.HasOne(n => n.EmpresaCompradora)
                .WithMany()
                .HasForeignKey(n => n.IDEmpresaCompradora)
                .IsRequired();

            builder.Property(n => n.IDproduto)
                .IsRequired();

            builder.HasOne(n => n.Produto)
                .WithMany()
                .HasForeignKey(n => n.IDproduto)
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
                .HasDefaultValue(11) // Valor padrão é 11
                .IsRequired();
        }
    }
}
