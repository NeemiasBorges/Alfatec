using Alfatec.Domain.Validations;

namespace Alfatec.Domain.Entities
{
    public class Negociacao
    {
        public Negociacao()
        {
        }
        public Negociacao(int id, DateTime dataNegociacao, int idEmpresaVendedora, int idEmpresaCompradora, int metodoEnvio, string metodoPagamento, DateTime previsaoEntrega, string statusPagamento)
        {
            ValidateDomain(id, dataNegociacao, idEmpresaVendedora, idEmpresaCompradora, metodoEnvio, metodoPagamento, previsaoEntrega, statusPagamento);

            Id = id;
            DataNegociacao = dataNegociacao;
            IdEmpresaVendedora = idEmpresaVendedora;
            IdEmpresaCompradora = idEmpresaCompradora;
            MetodoEnvio = metodoEnvio;
            MetodoPagamento = metodoPagamento;
            PrevisaoEntrega = previsaoEntrega;
            StatusPagamento = statusPagamento;
        }


        private void ValidateDomain(int id, DateTime dataNegociacao, int idEmpresaVendedora, int idEmpresaCompradora, int metodoEnvio, string metodoPagamento, DateTime previsaoEntrega, string statusPagamento)
        {
            DomainExceptionValidation.When(id <= 0, "ID inválido");
            DomainExceptionValidation.When(dataNegociacao == default(DateTime), "Data da negociação é obrigatória");
            DomainExceptionValidation.When(idEmpresaVendedora <= 0, "ID da empresa vendedora é obrigatório");
            DomainExceptionValidation.When(idEmpresaCompradora <= 0, "ID da empresa compradora é obrigatório");
            DomainExceptionValidation.When(metodoEnvio <= 0, "Método de envio é obrigatório");
            DomainExceptionValidation.When(string.IsNullOrEmpty(metodoPagamento), "Método de pagamento é obrigatório");
            DomainExceptionValidation.When(metodoPagamento != "Cartão Crédito" && metodoPagamento != "PIX" && metodoPagamento != "Boleto" && metodoPagamento != "Dinheiro", "Método de pagamento inválido. Os valores válidos são 'Cartão Crédito', 'PIX', 'Boleto' ou 'Dinheiro'");
            DomainExceptionValidation.When(previsaoEntrega == default(DateTime), "Previsão de entrega é obrigatória");
            DomainExceptionValidation.When(string.IsNullOrEmpty(statusPagamento), "Status do pagamento é obrigatório");
            DomainExceptionValidation.When(statusPagamento != "Pendente" && statusPagamento != "Pago" && statusPagamento != "A Prazo", "Status do pagamento inválido. Os valores válidos são 'Pendente', 'Pago' ou 'A Prazo'");
        }

        public int Id { get; private set; }
        public DateTime DataNegociacao { get; private set; }
        public int IdEmpresaVendedora { get; private set; }
        public int IdEmpresaCompradora { get; private set; }
        public int MetodoEnvio { get; private set; }
        public string MetodoPagamento { get; private set; }
        public DateTime PrevisaoEntrega { get; private set; }
        public string StatusPagamento { get; private set; }
        public int TipoObjeto { get; private set; } = 11;
    }
}
