using System.ComponentModel.DataAnnotations;

namespace Alfatec.Application.DTOs
{
    public class ServicosUsuarioDTO
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdServico { get; set; }
        [Required(ErrorMessage = "O nome do serviço é obrigatório")]
        public string NomeServico { get; set; }
        [Required(ErrorMessage = "A descrição é obrigatória")]
        public string Descricao { get; set; }
        public int TipoObjeto { get; set; } = 24;
    }
}
