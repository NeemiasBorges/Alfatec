using Alfatec.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Alfatec.Infra.Data.EntitiesConfiguration
{
    public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.NomeEmpresa)
                .IsRequired()
                .HasMaxLength(80);

            builder.Property(e => e.Tipo)
                .IsRequired()
                .HasMaxLength(10)
                .HasConversion<string>(); 

            builder.Property(e => e.Email)
                .IsRequired();

            builder.Property(e => e.Grupo)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.IdEndereco)
                .IsRequired();

            builder.Property(e => e.AreaAtuacao)
                .HasMaxLength(125);

            builder.Property(e => e.VendasConcluidas)
                .IsRequired();

            builder.Property(e => e.Classificacao)
                .IsRequired();

            builder.Property(e => e.CNPJ)
                .IsRequired();

            builder.Property(e => e.DataCriacao)
                .IsRequired();

            builder.Property(e => e.TipoObjeto)
                .HasDefaultValue(3)
            .IsRequired();

        }
    }
}
