using Alfatec.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alfatec.Infra.Data.EntitiesConfiguration
{
    public class LogConfiguation
    {
        public void Configure(EntityTypeBuilder<Log> builder)
        {
            builder.HasKey(l => l.Id);

            builder.Property(l => l.NomeCampoAlterado)
                .IsRequired();

            builder.Property(l => l.Usuario)
                .IsRequired();

            builder.Property(l => l.AntigoValor)
                .IsRequired();

            builder.Property(l => l.TipoObjetoAlterado)
                .IsRequired();

            builder.Property(l => l.NovoValor)
                .IsRequired();

            builder.Property(l => l.TipoObjeto)
                .HasDefaultValue(13) 
                .IsRequired();
        }
    }
}
