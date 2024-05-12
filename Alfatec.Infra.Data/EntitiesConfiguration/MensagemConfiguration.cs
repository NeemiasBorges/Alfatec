using Alfatec.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alfatec.Infra.Data.EntitiesConfiguration
{
    public class MensagemConfiguration : IEntityTypeConfiguration<Mensagem>
    {
        public void Configure(EntityTypeBuilder<Mensagem> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Destinatario)
                   .IsRequired();

            builder.Property(m => m.Remetente)
                   .IsRequired();

            builder.Property(m => m.MensagemTexto)
                   .IsRequired();

            builder.Property(m => m.StatusEnvio)
                   .IsRequired();

            builder.Property(m => m.DataEnvio)
                   .IsRequired();

            builder.HasOne(m => m.Modelo)
                   .WithMany() 
                   .HasForeignKey(m => m.IdModelo)
                   .IsRequired();
        }
    }
}
