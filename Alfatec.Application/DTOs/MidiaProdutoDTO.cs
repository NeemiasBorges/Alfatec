using System.ComponentModel.DataAnnotations;

namespace Alfatec.Application.DTOs
{
    public class MidiaProdutoDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O ID do produto é obrigatório")]
        public int IDproduto { get; set; }

        public ProdutoDTO Produto { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O tipo de arquivo é obrigatório")]
        public string TipoArquivo { get; set; }

        [Required(ErrorMessage = "O diretório é obrigatório")]
        public string Diretorio { get; set; }

        public int TipoObjeto { get; private set; } = 9;
    }
}
