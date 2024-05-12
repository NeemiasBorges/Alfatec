using Alfatec.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alfatec.Infra.Data.EntitiesConfiguration
{
    public class ComentarioConfiguration : IEntityTypeConfiguration<Comentario>
    {
        public void Configure(EntityTypeBuilder<Comentario> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.UsuarioQueComentou)
                .IsRequired();

            builder.Property(c => c.DataComentario)
                .IsRequired();

            builder.Property(c => c.ComentarioTexto)
                .IsRequired()
                .HasMaxLength(25600);

            builder.Property(c => c.TipoObjeto)
                .HasDefaultValue(6) 
                .IsRequired();
        }

    }
}
