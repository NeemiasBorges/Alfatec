using System.ComponentModel.DataAnnotations;

namespace Alfatec.Application.DTOs
{
    public class SeloDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do selo é obrigatório")]
        [MaxLength(30, ErrorMessage = "O nome do selo deve ter no máximo 30 caracteres")]
        public string NomeSelo { get; set; }

        [Required(ErrorMessage = "A data de criação do selo é obrigatória")]
        public DateTime DataCriacao { get; set; }

        public int TipoObjeto { get; private set; } = 8;
    }
}
