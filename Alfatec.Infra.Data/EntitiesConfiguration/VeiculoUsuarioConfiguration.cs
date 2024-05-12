using Alfatec.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alfatec.Infra.Data.EntitiesConfiguration
{
    public class VeiculoUsuarioConfiguration : IEntityTypeConfiguration<VeiculoUsuario>
    {
        public void Configure(EntityTypeBuilder<VeiculoUsuario> builder)
        {
            builder.HasKey(vu => vu.Id);

            builder.Property(vu => vu.Marca)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(vu => vu.Modelo)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(vu => vu.Placa)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(vu => vu.Cor)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(vu => vu.TipoCombustivel)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(vu => vu.DataUltimaManutencao)
                .IsRequired();

            builder.Property(vu => vu.Observacoes)
                .HasMaxLength(200);

            builder.HasOne(vu => vu.Usuario)
                .WithMany()
                .HasForeignKey(vu => vu.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(vu => vu.Veiculo)
                .WithMany()
                .HasForeignKey(vu => vu.VeiculoId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(e => e.TipoObjeto)
            .HasDefaultValue(22)
            .IsRequired();
        }
    }
}
