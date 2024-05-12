using Alfatec.Domain.Validations;
using System.Collections.Generic;

namespace Alfatec.Domain.Entities
{
    public class Mensagem
    {
        public Mensagem(){}
        public Mensagem(int id, string destinatario, string remetente, string mensagem, string statusEnvio, DateTime dataEnvio)
        {
            ValidateDomain(id, destinatario, mensagem, statusEnvio, dataEnvio);

            Id = id;
            Destinatario = destinatario;
            Remetente = remetente;
            MensagemTexto = mensagem;
            StatusEnvio = statusEnvio;
            DataEnvio = dataEnvio;
        }

        private void ValidateDomain(int id, string destinatario, string mensagem, string statusEnvio, DateTime dataEnvio)
        {
            DomainExceptionValidation.When(id <= 0, "ID inválido");
            DomainExceptionValidation.When(string.IsNullOrEmpty(destinatario), "Destinatário é obrigatório");
            DomainExceptionValidation.When(string.IsNullOrEmpty(mensagem), "Mensagem é obrigatória");
            DomainExceptionValidation.When(string.IsNullOrEmpty(statusEnvio), "Status de envio é obrigatório");
            DomainExceptionValidation.When(dataEnvio == default(DateTime), "Data de envio é obrigatória");
        }

        public int Id { get; private set; }
        public string Destinatario { get; private set; }
        public string Remetente { get; private set; }
        public string MensagemTexto { get; private set; }
        public string StatusEnvio { get; private set; }
        public DateTime DataEnvio { get; private set; }
        public int IdModelo { get; private set; }
        public ModeloMensagem Modelo { get; private set; }
        public int TipoObjeto { get; private set; } = 18;

    }
}
