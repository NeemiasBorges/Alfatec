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

            builder.Property(c => c.IdProduto)
                .IsRequired();

            builder.Property(c => c.IdUsuario)
                .IsRequired();

            builder.Property(c => c.Data)
                .IsRequired();

            builder.Property(c => c.TextoComentario)
                .IsRequired();

            builder.Property(c => c.TipoObjeto)
                .HasDefaultValue(5) // Valor padrão é 5
                .IsRequired();

            builder.HasOne(c => c.Produto)
                 .WithMany(p => p.Comentarios)  // Produto tem muitos Comentarios
                 .HasForeignKey(c => c.IdProduto)
                 .IsRequired();
        }
    }
}
