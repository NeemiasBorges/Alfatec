using Alfatec.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Alfatec.Infra.Data.EntitiesConfiguration
{
    public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .IsRequired();

            builder.Property(e => e.NomeEmpresa)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Tipo)
                .IsRequired()
                .HasMaxLength(12);

            builder.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(e => e.Grupo)
                .IsRequired();

            builder.Property(e => e.IDEndereco)
                .IsRequired();

            builder.Property(e => e.AreaAtuacao)
                .IsRequired();

            builder.Property(e => e.VendasConcluidas)
                .IsRequired();

            builder.Property(e => e.Classificacao)
                .IsRequired();

            builder.Property(e => e.CNPJ)
                .IsRequired()
                .HasMaxLength(14);

            builder.Property(e => e.IE)
                .IsRequired()
                .HasMaxLength(12);

            builder.Property(e => e.DataCriacao)
                .IsRequired();

            builder.Property(e => e.TipoObjeto)
                .HasDefaultValue(3) // Valor padrão é 3
                .IsRequired();

            builder.HasMany(e => e.Usuario)
                .WithOne(u => u.Empresa)
                .HasForeignKey(u => u.IDEmpresa);

        }
    }
}
