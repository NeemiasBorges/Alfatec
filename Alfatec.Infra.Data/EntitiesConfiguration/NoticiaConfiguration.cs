using Alfatec.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alfatec.Infra.Data.EntitiesConfiguration
{
    public class NoticiaConfiguration : IEntityTypeConfiguration<Noticia>
    {
        public void Configure(EntityTypeBuilder<Noticia> builder)
        {
            builder.HasKey(n => n.Id); // Define a propriedade Id como chave primária

            builder.Property(n => n.Titulo)
                .IsRequired() // O título é obrigatório
                .HasMaxLength(255); // Tamanho máximo de 255 caracteres

            builder.Property(n => n.Subtitulo)
                .HasMaxLength(100); // Tamanho máximo de 100 caracteres

            builder.Property(n => n.UsuarioId)
                .IsRequired(); // O ID do usuário é obrigatório

            builder.Property(n => n.DataHoraCriacao)
                .IsRequired(); // A data e hora de criação são obrigatórias

            builder.Property(n => n.CaminhoImagem)
                .IsRequired() // O caminho da imagem é obrigatório
                .HasMaxLength(255); // Tamanho máximo de 255 caracteres;
        }
    }
}
