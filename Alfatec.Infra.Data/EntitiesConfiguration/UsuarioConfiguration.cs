using Alfatec.Domain.Entities;
using Alfatec.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class UsuarioConfiguration : IEntityTypeConfiguration<Usuarios>
{
    public void Configure(EntityTypeBuilder<Usuarios> builder)
    {
        builder.HasKey(u => u.Id);


        builder.Property(u => u.Nome)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(u => u.CorTemaEmpresa)
            .HasMaxLength(8);

        builder.Property(u => u.Tipo)
            .IsRequired()
            .HasMaxLength(12);

        builder.Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(u => u.NomeEmpresa)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(u => u.Senha)
            .IsRequired()
            .HasMaxLength(12);

        builder.Property(u => u.IDEmpresa)
            .IsRequired();

        builder.Property(u => u.IdAutorizacao)
            .IsRequired();
        builder.Property(u => u.IDMidiaUsuario)
            .IsRequired();
        builder.Property(u => u.Cargo)
            .HasMaxLength(20);
        builder.Property(u => u.DDD)
            .HasMaxLength(4);
        builder.Property(u => u.Telefone)
            .HasMaxLength(9);
        builder.Property(u => u.TipoObjeto)
            .HasDefaultValue(1)
            .IsRequired();

        builder.HasOne(u => u.Empresa)
            .WithMany(e => e.Usuario)
            .HasForeignKey(u => u.IDEmpresa)
            .IsRequired();

        builder.HasOne(u => u.Autorizacoes)
        .WithOne(a => a.Usuario)
            .HasForeignKey<Usuarios>(u => u.IdAutorizacao);

        builder.HasOne(u => u.MidiaUsuario)
        .WithOne(m => m.Usuario)
            .HasForeignKey<Usuarios>(u => u.IDMidiaUsuario);



    }
}
