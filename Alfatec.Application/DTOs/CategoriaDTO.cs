using System.ComponentModel.DataAnnotations;

namespace Alfatec.Application.DTOs
{
    public class CategoriaDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome da categoria é obrigatório")]
        [StringLength(50, ErrorMessage = "O nome da categoria deve ter no máximo 50 caracteres")]
        public string NomeCategoria { get; set; }

        public DateTime DataCriacao { get; set; }
        public int TipoObjeto { get; set; }
    }
}
