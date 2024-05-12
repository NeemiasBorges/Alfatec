using Alfatec.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alfatec.Infra.Data.EntitiesConfiguration
{
    public class AutorizacaoConfiguration : IEntityTypeConfiguration<Autorizacao>
    {
        public void Configure(EntityTypeBuilder<Autorizacao> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Bloqueado)
                .IsRequired()
                .HasMaxLength(1)
                .HasConversion<string>(); 
            builder.Property(a => a.EditarProduto)
                .IsRequired()
                .HasMaxLength(1)
                .HasConversion<string>();
            builder.Property(a => a.InserirProduto)
                .IsRequired()
                .HasMaxLength(1)
                .HasConversion<string>();
            builder.Property(a => a.DesativarProduto)
                .IsRequired()
                .HasMaxLength(1)
                .HasConversion<string>();
            builder.Property(a => a.EditarInformacoesEmpresa)
                .IsRequired()
                .HasMaxLength(1)
                .HasConversion<string>();
            builder.Property(a => a.EditarInformacoesUsuario)
                .IsRequired()
                .HasMaxLength(1)
                .HasConversion<string>();
            builder.Property(a => a.AcessoModuloContato)
                .IsRequired()
                .HasMaxLength(1)
                .HasConversion<string>();

            builder.Property(a => a.TipoObjeto)
                .HasDefaultValue(2) 
                .IsRequired();
        }
    }
}
