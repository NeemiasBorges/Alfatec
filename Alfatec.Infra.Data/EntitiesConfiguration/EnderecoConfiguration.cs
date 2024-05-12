using Alfatec.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alfatec.Infra.Data.EntitiesConfiguration
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Nome)
                .IsRequired(false);
            
            builder.Property(e => e.Rua)
                .IsRequired(false);

            builder.Property(e => e.Bairro)
                .IsRequired(false);
            
            builder.Property(e => e.Numero)
                .IsRequired(false);

            builder.Property(e => e.CEP)
                .IsRequired(false);

            builder.Property(e => e.Complemento)
                .IsRequired(false)
                .HasDefaultValue("-");

            builder.Property(e => e.UF)
                .IsRequired(false);

            builder.Property(e => e.Observacoes)
                .HasMaxLength(256)
                .HasDefaultValue("-");
            
            builder.Property(e => e.latitude)
                .HasMaxLength(256);
            
            builder.Property(e => e.longitude)
                .HasMaxLength(256);

            builder.Property(e => e.TipoObjeto)
                .HasDefaultValue(8)
                .IsRequired();
        }
    }
}
