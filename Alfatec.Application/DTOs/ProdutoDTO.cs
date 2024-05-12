using System.ComponentModel.DataAnnotations;

namespace Alfatec.Application.DTOs
{
    public class ProdutoDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do produto é obrigatório")]
        [StringLength(80, ErrorMessage = "O nome do produto deve ter no máximo 80 caracteres")]
        public string NomeProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public string Status { get; set; } = "S";
        [Required(ErrorMessage = "A categoria é obrigatória")]
        public int Categoria { get; set; }
        [Required(ErrorMessage = "A unidade de venda é obrigatória")]
        [StringLength(25, ErrorMessage = "A unidade de venda deve ter no máximo 25 caracteres")]
        public string UnidadeVenda { get; set; }
        [Required(ErrorMessage = "O ID das fotos é obrigatório")]
        public int IdFotos { get; set; }
        public string Variacao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? Validade { get; set; }
        public string Selo { get; set; }
        public string FotoProduto { get; set; }
        public int Classificacao { get; set; }
        public int Comentarios { get; set; }
        public string ComentariosAdicionais { get; set; }
        public int TipoObjeto { get; set; } = 4;
        public int IdMidiaProduto { get; set; }
    }
}
