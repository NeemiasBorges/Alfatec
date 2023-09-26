using Alfatec.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Runtime.ConstrainedExecution;

namespace Alfatec.Infra.Data.EntitiesConfiguration
{
    public class AutorizacoesConfiguration : IEntityTypeConfiguration<Autorizacoes>
    {
        public void Configure(EntityTypeBuilder<Autorizacoes> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Bloqueado)
                .IsRequired()
                .HasMaxLength(1);
            builder.Property(a => a.EditarProduto)
                .IsRequired()
                .HasMaxLength(1);
            builder.Property(a => a.InserirProduto)
                .IsRequired()
                .HasMaxLength(1);
            builder.Property(a => a.DesativarProduto)
                .IsRequired()
                .HasMaxLength(1);
            builder.Property(a => a.EditarInformacoesEmpresa)
                .IsRequired()
                .HasMaxLength(1);
            builder.Property(a => a.EditarInformacoesUsuario)
                .IsRequired()
                .HasMaxLength(1);
            builder.Property(a => a.AcessoModuloContato)
                .IsRequired()
                .HasMaxLength(1);
            builder.Property(a => a.TipoObjeto)
                 .HasDefaultValue(2) // Valor padrão é 5
                .IsRequired();

            builder.HasOne(a => a.Usuario)
           .WithOne(u => u.Autorizacoes)
           .HasForeignKey<Autorizacoes>(a => a.Id)
           .IsRequired();
        }
    }
}
