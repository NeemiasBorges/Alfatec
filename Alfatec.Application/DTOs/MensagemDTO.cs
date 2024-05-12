using System;
using System.ComponentModel.DataAnnotations;

namespace Alfatec.Application.DTOs
{
    public class MensagemDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O destinatário é obrigatório")]
        public string Destinatario { get; set; }

        public string Remetente { get; set; }

        [Required(ErrorMessage = "A mensagem é obrigatória")]
        public string MensagemTexto { get; set; }

        [Required(ErrorMessage = "O status de envio é obrigatório")]
        public string StatusEnvio { get; set; }

        [Required(ErrorMessage = "A data de envio é obrigatória")]
        public DateTime DataEnvio { get; set; }

        public int IdModelo { get; set; }
        public int TipoObjeto { get; private set; } = 18;
    }
}
