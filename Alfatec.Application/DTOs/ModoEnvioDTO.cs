using System;
using System.ComponentModel.DataAnnotations;

namespace Alfatec.Application.DTOs
{
    public class ModoEnvioDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome da transportadora é obrigatório")]
        public string NomeTransportadora { get; set; }

        [Required(ErrorMessage = "O CNPJ da transportadora é obrigatório")]
        public string CNPJTransportadora { get; set; }

        [Required(ErrorMessage = "A inscrição estadual da transportadora é obrigatória")]
        public string IETransportadora { get; set; }

        [Required(ErrorMessage = "O cálculo da previsão de entrega é obrigatório")]
        public string CalculoPrevisaoEntrega { get; set; }
        [Required(ErrorMessage = "O tipo de envio é obrigatório")]
        public string TipoEnvio { get; set; }
        public int TipoObjeto { get; private set; } = 12;
    }
}
