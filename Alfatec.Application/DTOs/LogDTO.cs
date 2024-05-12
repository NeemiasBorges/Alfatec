using System;
using System.ComponentModel.DataAnnotations;

namespace Alfatec.Application.DTOs
{
    public class LogDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do campo alterado é obrigatório")]
        public string NomeCampoAlterado { get; set; }

        [Required(ErrorMessage = "O ID do usuário é obrigatório")]
        public int Usuario { get; set; }

        [Required(ErrorMessage = "O antigo valor é obrigatório")]
        public string AntigoValor { get; set; }

        [Required(ErrorMessage = "O tipo do objeto alterado é obrigatório")]
        public int TipoObjetoAlterado { get; set; }

        [Required(ErrorMessage = "O novo valor é obrigatório")]
        public string NovoValor { get; set; }

        public int TipoObjeto { get; private set; } = 13;
    }
}
