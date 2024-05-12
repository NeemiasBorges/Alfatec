using Alfatec.Domain.Validations;

namespace Alfatec.Domain.Entities
{
    public class Autorizacao
    {
        public Autorizacao(int id, string bloqueado, string editarProduto, string inserirProduto, string desativarProduto, string editarInformacoesEmpresa, string editarInformacoesUsuario, string acessoModuloContato)
        {
            ValidateDomain(id, bloqueado, editarProduto, inserirProduto, desativarProduto, editarInformacoesEmpresa, editarInformacoesUsuario, acessoModuloContato);

            Id = id;
            Bloqueado = bloqueado;
            EditarProduto = editarProduto;
            InserirProduto = inserirProduto;
            DesativarProduto = desativarProduto;
            EditarInformacoesEmpresa = editarInformacoesEmpresa;
            EditarInformacoesUsuario = editarInformacoesUsuario;
            AcessoModuloContato = acessoModuloContato;
        }

        private void ValidateDomain(int id, string bloqueado, string editarProduto, string inserirProduto, string desativarProduto, string editarInformacoesEmpresa, string editarInformacoesUsuario, string acessoModuloContato)
        {
            DomainExceptionValidation.When(id <= 0, "ID inválido");
            DomainExceptionValidation.When(bloqueado != "S" && bloqueado != "N", "Valor inválido para 'Bloqueado'. Deve ser 'S' ou 'N'");
            DomainExceptionValidation.When(editarProduto != "S" && editarProduto != "N", "Valor inválido para 'Editar Produto'. Deve ser 'S' ou 'N'");
            DomainExceptionValidation.When(inserirProduto != "S" && inserirProduto != "N", "Valor inválido para 'Inserir Produto'. Deve ser 'S' ou 'N'");
            DomainExceptionValidation.When(desativarProduto != "S" && desativarProduto != "N", "Valor inválido para 'Desativar Produto'. Deve ser 'S' ou 'N'");
            DomainExceptionValidation.When(editarInformacoesEmpresa != "S" && editarInformacoesEmpresa != "N", "Valor inválido para 'Editar Informações da Empresa'. Deve ser 'S' ou 'N'");
            DomainExceptionValidation.When(editarInformacoesUsuario != "S" && editarInformacoesUsuario != "N", "Valor inválido para 'Editar Informações do Usuário'. Deve ser 'S' ou 'N'");
            DomainExceptionValidation.When(acessoModuloContato != "S" && acessoModuloContato != "N", "Valor inválido para 'Acesso ao Módulo de Contato'. Deve ser 'S' ou 'N'");
        }

        public int Id { get; private set; }
        public string Bloqueado { get; private set; }
        public string EditarProduto { get; private set; }
        public string InserirProduto { get; private set; }
        public string DesativarProduto { get; private set; }
        public string EditarInformacoesEmpresa { get; private set; }
        public string EditarInformacoesUsuario { get; private set; }
        public string AcessoModuloContato { get; private set; }
        public int TipoObjeto { get; private set; } = 2;
    }
}
