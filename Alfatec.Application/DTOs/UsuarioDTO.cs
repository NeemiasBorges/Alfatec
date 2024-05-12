using System.ComponentModel.DataAnnotations;

namespace Alfatec.Application.DTOs
{
    public class UsuarioDTO
    {
        public UsuarioDTO(){}
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(25, ErrorMessage = "O nome deve ter no máximo 25 caracteres")]
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "O tipo é obrigatório")]
        [StringLength(1, ErrorMessage = "O tipo deve ter no máximo 1 caractere")]
        [RegularExpression("ADM|PRS|AGR|MRC", ErrorMessage = "Tipo inválido")]
        public string Tipo { get; set; } = "USR";

        public string Email { get; set; } = "";
        public string NomeEmpresa { get; set; } = "Alfatec";
        public string Senha { get; set; } = "";
        public int IDEmpresa { get; set; }
        public int IdAutorizacao { get; set; }
        public int IdMidiaUsuario { get; set; }

        [Required(ErrorMessage = "O DDD é obrigatório")]
        public int DDD { get; set; }

        [Required(ErrorMessage = "O telefone é obrigatório")]
        public string Telefone { get; set; }
        public EnderecoDTO Endereco { get; set; }

        public int TipoObjeto { get; set; } = 1;
    }
}
