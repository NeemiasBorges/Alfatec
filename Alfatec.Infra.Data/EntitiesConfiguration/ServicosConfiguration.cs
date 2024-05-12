using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Alfatec.Domain.Entities;

namespace Alfatec.Infrastructure.Persistence.Configurations
{
    public class ServicosConfiguration : IEntityTypeConfiguration<Servicos>
    {
        public void Configure(EntityTypeBuilder<Servicos> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.NomeServico).IsRequired();
            builder.Property(s => s.Descricao).IsRequired();

            builder.HasData(
                new Servicos { Id = 1, NomeServico = "Consultoria Agronômica", Descricao = "Orientação técnica para manejo de culturas." },
                new Servicos { Id = 2, NomeServico = "Assistência Técnica", Descricao = "Acompanhamento regular para otimização agrícola." },
                new Servicos { Id = 3, NomeServico = "Logística de Transporte", Descricao = "Distribuição eficiente de produtos agrícolas." },
                new Servicos { Id = 4, NomeServico = "Armazenagem Pós-Colheita", Descricao = "Controle e distribuição segura de colheitas." },
                new Servicos { Id = 5, NomeServico = "Serviços de Máquinas Agrícolas", Descricao = "Aluguel e manutenção de equipamentos agrícolas." },
                new Servicos { Id = 6, NomeServico = "Análise de Solo e Nutrição de Plantas", Descricao = "Avaliação e recomendação de fertilizantes." },
                new Servicos { Id = 7, NomeServico = "Tecnologia Agrícola e Digital", Descricao = "Soluções tecnológicas para otimização agrícola." },
                new Servicos { Id = 8, NomeServico = "Serviços de Irrigação", Descricao = "Projetos e manutenção de sistemas de irrigação." },
                new Servicos { Id = 9, NomeServico = "Gestão Ambiental e Sustentabilidade", Descricao = "Práticas sustentáveis para a agricultura." },
                new Servicos { Id = 10, NomeServico = "Assistência Jurídica e Administrativa", Descricao = "Assessoria legal e administrativa para fazendas." },
                new Servicos { Id = 11, NomeServico = "Marketing Agrícola", Descricao = "Estratégias de promoção e vendas de produtos." },
                new Servicos { Id = 12, NomeServico = "Educação e Treinamento Agrícola", Descricao = "Cursos e capacitação para agricultores." },
                new Servicos { Id = 13, NomeServico = "Seguro Agrícola", Descricao = "Proteção contra perdas devido a eventos adversos." },
                new Servicos { Id = 14, NomeServico = "Genética e Melhoramento Vegetal", Descricao = "Desenvolvimento de variedades de plantas." },
                new Servicos { Id = 15, NomeServico = "Contabilidade e Finanças Agrícolas", Descricao = "Gestão financeira e tributária para fazendas." },
                new Servicos { Id = 16, NomeServico = "Certificação e Qualidade", Descricao = "Garantia de padrões de qualidade e conformidade." },
                new Servicos { Id = 17, NomeServico = "Produção de Sementes e Mudas", Descricao = "Produção e comercialização de materiais genéticos." },
                new Servicos { Id = 18, NomeServico = "Energias Renováveis", Descricao = "Implementação de fontes de energia limpa em fazendas." },
                new Servicos { Id = 19, NomeServico = "Controle de Pragas e Doenças", Descricao = "Prevenção e combate a problemas fitossanitários." },
                new Servicos { Id = 20, NomeServico = "Consultoria de Mercado", Descricao = "Análise e insights sobre tendências e demanda do mercado agrícola." },
                new Servicos { Id = 21, NomeServico = "Locação Equipamentos", Descricao = "Locação Equipamentos." }

            );

            builder.Property(e => e.TipoObjeto)
    .HasDefaultValue(23)
    .IsRequired();
        }
    }
}
