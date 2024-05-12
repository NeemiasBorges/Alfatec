using Alfatec.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alfatec.Infra.Data.EntitiesConfiguration
{
    public class CondicoesEstradaConfiguration : IEntityTypeConfiguration<CondicoesEstrada>
    {
        public void Configure(EntityTypeBuilder<CondicoesEstrada> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Localizacao)
                .IsRequired()
                .HasMaxLength(255); 

            builder.Property(c => c.Observacoes)
                .IsRequired()
                .HasMaxLength(1000); 

            builder.Property(c => c.TipoObjeto)
                .IsRequired()
                .HasDefaultValue(16); 
        }
    }
}
