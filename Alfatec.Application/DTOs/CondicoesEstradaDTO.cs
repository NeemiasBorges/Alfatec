using System;
using System.ComponentModel.DataAnnotations;

namespace Alfatec.Application.DTOs
{
    public class CondicoesEstradaDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "A localização é obrigatória")]
        public string Localizacao { get; set; }
        [Required(ErrorMessage = "A data de registro é obrigatória")]
        public DateTime DataRegistro { get; set; }
        [Required(ErrorMessage = "As observações são obrigatórias")]
        public string Observacoes { get; set; }
        public int TipoObjeto { get; private set; } = 16;
    }
}
