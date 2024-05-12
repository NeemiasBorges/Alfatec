using Alfatec.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alfatec.Infra.Data.Configurations
{
    public class ModeloMensagemConfiguration : IEntityTypeConfiguration<ModeloMensagem>
    {
        public void Configure(EntityTypeBuilder<ModeloMensagem> builder)
        {
            builder.HasKey(mm => mm.Id);

            builder.Property(mm => mm.nomeModelo)
                   .HasMaxLength(255)
                   .IsRequired();

            builder.Property(mm => mm.TextoModelo)
                   .IsRequired();

            builder.HasData(
                new ModeloMensagem
                {
                    Id = 1,
                    nomeModelo = "Primeiro Acesso",
                    TextoModelo = @"Olá {{NomeUsuario}},

Seja bem-vindo à nossa plataforma! Estamos muito felizes em tê-lo(a) conosco.

Seu cadastro foi realizado com sucesso usando o email: {{Email}}.
Tipo de usuário cadastrado: [Tipo de usuário]
Para acessar sua conta pela primeira vez, utilize a seguinte senha temporária: {{SenhaTemp}}. Recomendamos que você altere sua senha assim que fizer login.
Para acessar nossa plataforma, clique no link abaixo:

{{Link de acesso}}"
                },
                new ModeloMensagem
                {
                    Id = 2,
                    nomeModelo = "Notifica Servico",
                    TextoModelo = @"Olá {{NomeUsuario}},

Um novo serviço baseado em seu perfil acabou de aparecer. Se estiver interessado, por favor, responda com o número 1. Segue o resumo:
Transporte de carga {{TipoCarga}}, aproximadamente {{PesoCarga}}} Kilos para o endereço:
{{Endereco}}.

As condições da via são: {{CondicoesVia}}.

O tempo total da viagem de ida é de aproximadamente {{TempoAproximado}} horas com o valor de {{ValorHora}} reais por hora, totalizando {{Total}} reais.
Ficamos no aguardo de sua resposta."
                },
                new ModeloMensagem
                {
                    Id = 3,
                    nomeModelo = "Resetar Senha",
                    TextoModelo = @"Olá {{NomeUsuario}},

Você solicitou uma nova senha. Sua nova senha é: {{NovaSenha}}."
                }
            );
        }
    }
}
