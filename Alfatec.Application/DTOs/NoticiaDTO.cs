using System.ComponentModel.DataAnnotations;

namespace Alfatec.Application.DTOs
{
    public class NoticiaDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O título da notícia é obrigatório.")]
        public string Titulo { get; set; }

        [StringLength(100, ErrorMessage = "O subtítulo deve ter no máximo 100 caracteres.")]
        public string Subtitulo { get; set; }

        [Required(ErrorMessage = "O ID do usuário é obrigatório.")]
        public int UsuarioId { get; set; }

        [Display(Name = "Data e Hora de Criação")]
        public DateTime DataHoraCriacao { get; set; }

        [Required(ErrorMessage = "O caminho da imagem é obrigatório.")]
        [Url(ErrorMessage = "O caminho da imagem deve ser uma URL válida.")]
        public string CaminhoImagem { get; set; }
    }
}
