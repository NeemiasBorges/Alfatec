using Alfatec.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alfatec.Infra.Data.EntitiesConfiguration
{
    public class ServicosUsuarioConfiguration : IEntityTypeConfiguration<ServicosUsuario>
    {
        public void Configure(EntityTypeBuilder<ServicosUsuario> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.NomeServico).IsRequired();
            builder.Property(s => s.Descricao).IsRequired();
            builder.Property(s => s.IdServico).IsRequired();
            builder.Property(s => s.IdUsuario).IsRequired();

            builder.Property(e => e.TipoObjeto)
    .HasDefaultValue(24)
    .IsRequired();
        }
    }
}
