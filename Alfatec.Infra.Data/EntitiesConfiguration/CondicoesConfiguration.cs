using Alfatec.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alfatec.Infra.Data.EntitiesConfiguration
{
    public class CondicoesConfiguration : IEntityTypeConfiguration<Condicoes>
    {
        public void Configure(EntityTypeBuilder<Condicoes> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .ValueGeneratedNever();

            builder.Property(c => c.Nome)
                .IsRequired();

            builder.HasData(
                new Condicoes { Id = 1,  Nome = "Estradas não pavimentadas" },
                new Condicoes { Id = 2,  Nome = "Buracos e irregularidades" },
                new Condicoes { Id = 3,  Nome = "Lama e alagamentos" },
                new Condicoes { Id = 4,  Nome = "Estradas estreitas" },
                new Condicoes { Id = 5,  Nome = "Declives e aclives pronunciados" },
                new Condicoes { Id = 6,  Nome = "Curvas fechadas e sinuosas" },
                new Condicoes { Id = 7,  Nome = "Presença de animais" },
                new Condicoes { Id = 8,  Nome = "Ausência de sinalização e iluminação" },
                new Condicoes { Id = 9,  Nome = "Condições climáticas extremas" },
                new Condicoes { Id = 10, Nome = "Falta de serviços de emergência" },
                new Condicoes { Id = 11, Nome = "Falta de acostamento" },
                new Condicoes { Id = 12, Nome = "Presença de pedras soltas" },
                new Condicoes { Id = 13, Nome = "Ponte de uma única faixa" },
                new Condicoes { Id = 14, Nome = "Vegetação sobre crescida" },
                new Condicoes { Id = 15, Nome = "Excesso Poeira" },
                new Condicoes { Id = 16, Nome = "Inclinações laterais" },
                new Condicoes { Id = 17, Nome = "Cruzamentos não sinalizados" },
                new Condicoes { Id = 18, Nome = "Presença de tratores e veículos agrícolas" },
                new Condicoes { Id = 19, Nome = "Estradas com manutenção irregular" },
                new Condicoes { Id = 20, Nome = "Riscos sazonais" }
            );
        }
    }
}
