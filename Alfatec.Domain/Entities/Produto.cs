using Alfatec.Domain.Validations;

namespace Alfatec.Domain.Entities
{
    public class Produto
    {
        public Produto(){}
        public Produto(int id, string nomeProduto, string descricaoProduto, string status, int categoria, string unidadeVenda, int idFotos, string variacao, DateTime dataCriacao, DateTime? validade, string selos, int classificacao, int comentarios, string comentariosAdicionais)
        {
            ValidateDomain(id, nomeProduto, descricaoProduto, status, categoria, unidadeVenda, idFotos, variacao, dataCriacao, validade, selos, classificacao, comentarios, comentariosAdicionais);

            Id                    = id;
            NomeProduto           = nomeProduto;
            DescricaoProduto      = descricaoProduto;
            Status                = status;
            Categoria             = categoria;
            UnidadeVenda          = unidadeVenda;
            IdFotos               = idFotos;
            Variacao              = variacao;
            DataCriacao           = dataCriacao;
            Validade              = validade;
            Selos                 = selos;
            Classificacao         = classificacao;
            Comentarios           = comentarios;
            ComentariosAdicionais = comentariosAdicionais;
        }

        private void ValidateDomain(int id, string nomeProduto, string descricaoProduto, string status, int categoria, string unidadeVenda, int idFotos, string variacao, DateTime dataCriacao, DateTime? validade, string selos, int classificacao, int comentarios, string comentariosAdicionais)
        {
            DomainExceptionValidation.When(id <= 0, "ID inválido");
            DomainExceptionValidation.When(string.IsNullOrEmpty(nomeProduto), "Nome do produto é obrigatório");
            DomainExceptionValidation.When(nomeProduto.Length > 80, "Nome do produto deve ter no máximo 80 caracteres");
            DomainExceptionValidation.When(string.IsNullOrEmpty(descricaoProduto), "Descrição do produto é obrigatória");
            DomainExceptionValidation.When(string.IsNullOrEmpty(status), "Status é obrigatório");
            DomainExceptionValidation.When(status != "N" && status != "S", "Status inválido. Os valores válidos são 'N' ou 'S'");
            DomainExceptionValidation.When(categoria <= 0, "Categoria é obrigatória");
            DomainExceptionValidation.When(string.IsNullOrEmpty(unidadeVenda), "Unidade de venda é obrigatória");
            DomainExceptionValidation.When(unidadeVenda.Length > 25, "Unidade de venda deve ter no máximo 25 caracteres");
            DomainExceptionValidation.When(idFotos <= 0, "ID das fotos é obrigatório");
        }

        public int Id { get; private set; }
        public string NomeProduto { get; private set; }
        public string DescricaoProduto { get; private set; }
        public string Status { get; private set; }
        public int Categoria { get; private set; }
        public string UnidadeVenda { get; private set; }
        public int IdFotos { get; private set; }
        public string Variacao { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime? Validade { get; private set; }
        public string Selos { get; private set; }
        public int Classificacao { get; private set; }
        public int Comentarios { get; private set; }
        public string ComentariosAdicionais { get; private set; }
        public int TipoObjeto { get; private set; } = 4;
        public int IdMidiaProduto { get; set; }
    }
}
