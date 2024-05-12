using System;
using System.ComponentModel.DataAnnotations;

namespace Alfatec.Application.DTOs
{
    public class NegociacaoDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A data da negociação é obrigatória")]
        public DateTime DataNegociacao { get; set; }

        [Required(ErrorMessage = "O ID da empresa vendedora é obrigatório")]
        public int IdEmpresaVendedora { get; set; }

        [Required(ErrorMessage = "O ID da empresa compradora é obrigatório")]
        public int IdEmpresaCompradora { get; set; }

        [Required(ErrorMessage = "O método de envio é obrigatório")]
        public int MetodoEnvio { get; set; }

        [Required(ErrorMessage = "O método de pagamento é obrigatório")]
        [RegularExpression("^(Cartão Crédito|PIX|Boleto|Dinheiro)$", ErrorMessage = "Método de pagamento inválido. Os valores válidos são 'Cartão Crédito', 'PIX', 'Boleto' ou 'Dinheiro'")]
        public string MetodoPagamento { get; set; }

        [Required(ErrorMessage = "A previsão de entrega é obrigatória")]
        public DateTime PrevisaoEntrega { get; set; }

        [Required(ErrorMessage = "O status do pagamento é obrigatório")]
        [RegularExpression("^(Pendente|Pago|A Prazo)$", ErrorMessage = "Status do pagamento inválido. Os valores válidos são 'Pendente', 'Pago' ou 'A Prazo'")]
        public string StatusPagamento { get; set; }

        public int TipoObjeto { get; private set; } = 11;
    }
}
