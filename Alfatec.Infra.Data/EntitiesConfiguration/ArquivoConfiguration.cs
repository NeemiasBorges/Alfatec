using Alfatec.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alfatec.Infra.Data.EntitiesConfiguration
{
    public class ArquivoConfiguration : IEntityTypeConfiguration<Arquivo>
    {
        public void Configure(EntityTypeBuilder<Arquivo> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.NomeArquivo)
                .IsRequired();
            builder.Property(a => a.TipoArquivo)
                .IsRequired()
                .HasMaxLength(3)
                .HasDefaultValue("JPG"); 
            builder.Property(a => a.Diretorio)
                .IsRequired();
            builder.Property(a => a.TipoObjeto)
                .IsRequired();
        }
    }
}
