using System.ComponentModel.DataAnnotations;

namespace Alfatec.Application.DTOs
{
    public class MidiaUsuarioDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do arquivo é obrigatório")]
        [StringLength(80, ErrorMessage = "O nome do arquivo deve ter no máximo 80 caracteres")]
        public string NomeArquivo { get; set; }

        [Required(ErrorMessage = "O tipo do arquivo é obrigatório")]
        [RegularExpression("JPG", ErrorMessage = "Tipo de arquivo inválido. O valor válido é 'JPG'")]
        public string TipoArquivo { get; set; }

        [Required(ErrorMessage = "O diretório é obrigatório")]
        public string Diretorio { get; set; }

        public int TipoObjeto { get; private set; } = 19;
    }
}
