using Alfatec.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

public class SeloConfiguration : IEntityTypeConfiguration<Selo>
{
    public void Configure(EntityTypeBuilder<Selo> builder)
    {
        builder.HasKey(s => s.Id);

        builder.Property(s => s.NomeSelo)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(s => s.DataCriacao)
            .IsRequired();

        builder.Property(s => s.TipoObjeto)
            .HasDefaultValue(8)
            .IsRequired();

        builder.HasData(
           new Selo { Id = 1,  NomeSelo = "Agricultura Familiar", DataCriacao = DateTime.Now },
           new Selo { Id = 2,  NomeSelo = "BRC Global Standards", DataCriacao = DateTime.Now },
           new Selo { Id = 3,  NomeSelo = "Demeter: Agricultura Biodinâmica", DataCriacao = DateTime.Now },
           new Selo { Id = 4,  NomeSelo = "Comércio Justo - Fair Trade", DataCriacao = DateTime.Now },
           new Selo { Id = 5,  NomeSelo = "ISO 22000: Segurança Alimentar", DataCriacao = DateTime.Now },
           new Selo { Id = 6,  NomeSelo = "Kosher: Alimentação Judaica", DataCriacao = DateTime.Now },
           new Selo { Id = 7,  NomeSelo = "Non-GMO Project Verified", DataCriacao = DateTime.Now },
           new Selo { Id = 8,  NomeSelo = "Orgânico Brasil", DataCriacao = DateTime.Now },
           new Selo { Id = 9,  NomeSelo = "SENAR: Agricultura Familiar", DataCriacao = DateTime.Now },
           new Selo { Id = 10, NomeSelo = "SISORG: Avaliação Orgânica", DataCriacao = DateTime.Now },
           new Selo { Id = 11, NomeSelo = "SQF: Segurança Alimentar", DataCriacao = DateTime.Now },
           new Selo { Id = 12, NomeSelo = "CCCF: Café, Cacau e Chá Sustentáveis", DataCriacao = DateTime.Now },
           new Selo { Id = 13, NomeSelo = "NSF International: Saúde Alimentar", DataCriacao = DateTime.Now },
           new Selo { Id = 14, NomeSelo = "ISO 9001: Qualidade", DataCriacao = DateTime.Now },
           new Selo { Id = 15, NomeSelo = "Fairtrade International", DataCriacao = DateTime.Now },
           new Selo { Id = 16, NomeSelo = "EU Organic", DataCriacao = DateTime.Now },
           new Selo { Id = 17, NomeSelo = "GFCO: Livre de Glúten", DataCriacao = DateTime.Now },
           new Selo { Id = 18, NomeSelo = "EcoCert: Ecológica", DataCriacao = DateTime.Now },
           new Selo { Id = 19, NomeSelo = "Vegan Action", DataCriacao = DateTime.Now },
           new Selo { Id = 20, NomeSelo = "Rainforest Alliance Agriculture", DataCriacao = DateTime.Now }

        );
    }
}
