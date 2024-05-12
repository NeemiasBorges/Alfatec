using System.ComponentModel.DataAnnotations;

namespace Alfatec.Application.DTOs
{
    public class AutorizacaoDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo 'Bloqueado' é obrigatório")]
        [RegularExpression("^[SN]$", ErrorMessage = "Valor inválido para 'Bloqueado'. Deve ser 'S' ou 'N'")]
        public string Bloqueado { get; set; }

        [Required(ErrorMessage = "O campo 'Editar Produto' é obrigatório")]
        [RegularExpression("^[SN]$", ErrorMessage = "Valor inválido para 'Editar Produto'. Deve ser 'S' ou 'N'")]
        public string EditarProduto { get; set; }

        [Required(ErrorMessage = "O campo 'Inserir Produto' é obrigatório")]
        [RegularExpression("^[SN]$", ErrorMessage = "Valor inválido para 'Inserir Produto'. Deve ser 'S' ou 'N'")]
        public string InserirProduto { get; set; }

        [Required(ErrorMessage = "O campo 'Desativar Produto' é obrigatório")]
        [RegularExpression("^[SN]$", ErrorMessage = "Valor inválido para 'Desativar Produto'. Deve ser 'S' ou 'N'")]
        public string DesativarProduto { get; set; }

        [Required(ErrorMessage = "O campo 'Editar Informações da Empresa' é obrigatório")]
        [RegularExpression("^[SN]$", ErrorMessage = "Valor inválido para 'Editar Informações da Empresa'. Deve ser 'S' ou 'N'")]
        public string EditarInformacoesEmpresa { get; set; }

        [Required(ErrorMessage = "O campo 'Editar Informações do Usuário' é obrigatório")]
        [RegularExpression("^[SN]$", ErrorMessage = "Valor inválido para 'Editar Informações do Usuário'. Deve ser 'S' ou 'N'")]
        public string EditarInformacoesUsuario { get; set; }

        [Required(ErrorMessage = "O campo 'Acesso ao Módulo de Contato' é obrigatório")]
        [RegularExpression("^[SN]$", ErrorMessage = "Valor inválido para 'Acesso ao Módulo de Contato'. Deve ser 'S' ou 'N'")]
        public string AcessoModuloContato { get; set; }

        public int TipoObjeto { get; set; } = 2;
    }
}
