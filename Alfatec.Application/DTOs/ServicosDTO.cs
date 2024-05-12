using System;
using System.ComponentModel.DataAnnotations;

namespace Alfatec.Application.DTOs
{
    public class ServicosDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do serviço é obrigatório")]
        public string NomeServico { get; set; }

        public string Descricao { get; set; }
        public string Classificacao { get; set; }

        public int TipoObjeto { get; set; } = 23;
    }
}
