using System;
using System.ComponentModel.DataAnnotations;

namespace Alfatec.Application.DTOs
{
    public class ComentarioDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O ID do usuário que comentou é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "ID do usuário que comentou inválido")]
        public int UsuarioQueComentou { get; set; }

        [Required(ErrorMessage = "A data do comentário é obrigatória")]
        public DateTime DataComentario { get; set; }

        [Required(ErrorMessage = "O comentário é obrigatório")]
        [StringLength(25600, ErrorMessage = "O comentário excede o limite de 25600 caracteres")]
        public string ComentarioTexto { get; set; }

        public int TipoObjeto { get; set; } = 6;
    }
}
