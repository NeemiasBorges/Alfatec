using Alfatec.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alfatec.Infra.Data.EntitiesConfiguration
{

    public class MidiaUsuarioConfiguration : IEntityTypeConfiguration<MidiaUsuario>
    {
        public void Configure(EntityTypeBuilder<MidiaUsuario> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Id)
                .IsRequired();

            builder.Property(m => m.NomeArquivo)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(m => m.TipoArquivo)
                .IsRequired();

            builder.Property(m => m.Diretorio)
                .IsRequired();

            builder.Property(m => m.TipoObjeto)
                .HasDefaultValue(10) 
                .IsRequired();

        }
    }
}

