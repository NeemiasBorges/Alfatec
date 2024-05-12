using System;
using System.ComponentModel.DataAnnotations;

namespace Alfatec.Application.DTOs
{
    public class EmpresaDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome da empresa é obrigatório")]
        [StringLength(80, ErrorMessage = "O nome da empresa deve ter no máximo 80 caracteres")]
        public string NomeEmpresa { get; set; }

        [Required(ErrorMessage = "O tipo é obrigatório")]
        [RegularExpression("^(Comércio|Produtor|Domiciliar)$", ErrorMessage = "Tipo inválido. Os valores válidos são 'Comércio', 'Produtor' ou 'Domiciliar'")]
        public string Tipo { get; set; }

        public string Email { get; set; }
        public string Grupo { get; set; }
        public int IdEndereco { get; set; }

        [StringLength(125, ErrorMessage = "A área de atuação deve ter no máximo 125 caracteres")]
        public string AreaAtuacao { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Vendas concluídas não podem ser negativas")]
        public int? VendasConcluidas { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Classificação não pode ser negativa")]
        public int? Classificacao { get; set; }
        public string CNPJ { get; set; }
        public string IE { get; set; }
        public DateTime DataCriacao { get; set; }
        public int TipoObjeto { get; private set; } = 3;
        public int IdUsuario { get; set; }
    }
}
