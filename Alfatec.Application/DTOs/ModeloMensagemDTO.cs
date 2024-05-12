using System.ComponentModel.DataAnnotations;

namespace Alfatec.Application.DTOs
{
    public class ModeloMensagemDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do modelo é obrigatório")]
        public string NomeModelo { get; set; }

        [Required(ErrorMessage = "O texto do modelo é obrigatório")]
        public string TextoModelo { get; set; }

        public int TipoObjeto { get; private set; } = 20;
    }
}
