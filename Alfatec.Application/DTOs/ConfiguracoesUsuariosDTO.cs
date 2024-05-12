using System.ComponentModel.DataAnnotations;

namespace Alfatec.Application.DTOs
{
    public class ConfiguracoesUsuarioDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome da configuração é obrigatório")]
        public string NomeConfiguracao { get; set; }
        public int TipoObjeto { get; private set; } = 17;
    }
}
