using Alfatec.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.HasKey(u => u.Id);

        builder.Property(u => u.Nome)
            .IsRequired()
            .HasMaxLength(25);

        builder.Property(u => u.Tipo)
            .IsRequired()
            .HasMaxLength(3);

        builder.Property(u => u.Email)
            .HasMaxLength(30);

        builder.Property(u => u.CNPJ)
             .HasMaxLength(14);

        builder.Property(u => u.NomeEmpresa)
            .HasMaxLength(50);

        builder.Property(u => u.Senha)
            .IsRequired()
            .HasMaxLength(16);

        builder.Property(u => u.IdEndereco);

        builder.Property(u => u.TipoObjeto)
            .HasDefaultValue(1)
            .IsRequired();

        builder.HasOne(mp => mp.Endereco)
       .WithMany()
       .HasForeignKey(mp => mp.IdEndereco)
       .IsRequired();
    }
}
