using System;
using System.ComponentModel.DataAnnotations;

namespace Alfatec.Application.DTOs
{
    public class EnderecoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [Required(ErrorMessage = "A rua é obrigatória")]
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Numero { get; set; }

        [Required(ErrorMessage = "O bairro é obrigatório")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O CEP é obrigatório")]
        public string CEP { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "A UF é obrigatória")]
        public string UF { get; set; }
        public string Observacoes { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public int TipoObjeto { get; private set; } = 8;
        public int IDCondicoesEstrada { get; set; }
        public CondicoesEstradaDTO Condicoes { get; set; }
    }
}
