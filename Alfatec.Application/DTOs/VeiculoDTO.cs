using System.ComponentModel.DataAnnotations;

namespace Alfatec.Application.DTOs
{
    public class VeiculoDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do veículo é obrigatório")]
        public string Nome { get; set; }

        public int TipoObjeto { get; set; } = 21;
    }
}
