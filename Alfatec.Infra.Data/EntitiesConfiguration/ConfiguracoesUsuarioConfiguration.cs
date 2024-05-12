using Alfatec.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alfatec.Infra.Data.EntitiesConfiguration
{
    public class ConfiguracoesUsuarioConfiguration : IEntityTypeConfiguration<ConfiguracoesUsuario>
    {
        public void Configure(EntityTypeBuilder<ConfiguracoesUsuario> builder)
        {
            builder.HasNoKey();
        }
    }
}
