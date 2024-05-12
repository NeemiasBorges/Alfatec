using Alfatec.Domain.Validations;

namespace Alfatec.Domain.Entities
{
    public class Empresa
    {
        public Empresa()
        {
        }
        public Empresa(int id, string nomeEmpresa, string tipo, string email, string grupo, int idEndereco, string areaAtuacao, int? vendasConcluidas, int? classificacao, string cnpj, string ie, DateTime dataCriacao)
        {
            ValidateDomain(id, nomeEmpresa, tipo, email, grupo, idEndereco, areaAtuacao, vendasConcluidas, classificacao, cnpj, ie, dataCriacao);

            Id = id;
            NomeEmpresa = nomeEmpresa;
            Tipo = tipo;
            Email = email;
            Grupo = grupo;
            IdEndereco = idEndereco;
            AreaAtuacao = areaAtuacao;
            VendasConcluidas = vendasConcluidas;
            Classificacao = classificacao;
            CNPJ = cnpj;
            IE = ie;
            DataCriacao = dataCriacao;
        }

        private void ValidateDomain(int id, string nomeEmpresa, string tipo, string email, string grupo, int idEndereco, string areaAtuacao, int? vendasConcluidas, int? classificacao, string cnpj, string ie, DateTime dataCriacao)
        {
            DomainExceptionValidation.When(id <= 0, "ID inválido");
            DomainExceptionValidation.When(string.IsNullOrEmpty(nomeEmpresa), "Nome da empresa é obrigatório");
            DomainExceptionValidation.When(nomeEmpresa.Length > 80, "Nome da empresa deve ter no máximo 80 caracteres");
            DomainExceptionValidation.When(string.IsNullOrEmpty(tipo), "Tipo é obrigatório");
            DomainExceptionValidation.When(tipo != "Comércio" && tipo != "Produtor" && tipo != "Domiciliar", "Tipo inválido. Os valores válidos são 'Comércio', 'Produtor' ou 'Domiciliar'");
            DomainExceptionValidation.When(string.IsNullOrEmpty(email), "Email é obrigatório");
            DomainExceptionValidation.When(!email.Contains("@"), "Email inválido");
            DomainExceptionValidation.When(string.IsNullOrEmpty(grupo), "Grupo é obrigatório");
            DomainExceptionValidation.When(grupo.Length > 50, "Grupo deve ter no máximo 50 caracteres");
            DomainExceptionValidation.When(idEndereco <= 0, "ID do endereço é obrigatório");
            DomainExceptionValidation.When(areaAtuacao.Length > 125, "Área de atuação deve ter no máximo 125 caracteres");
            DomainExceptionValidation.When(vendasConcluidas < 0, "Vendas concluídas não podem ser negativas");
            DomainExceptionValidation.When(classificacao < 0, "Classificação não pode ser negativa");
            DomainExceptionValidation.When(string.IsNullOrEmpty(cnpj), "CNPJ é obrigatório");
        }

        public int Id                { get; private set; }
        public string NomeEmpresa    { get; private set; }
        public string Tipo           { get; private set; }
        public string Telefone       { get; private set; }
        public string Email          { get; private set; }
        public string Grupo          { get; private set; }
        public string AreaAtuacao    { get; private set; }
        public int? VendasConcluidas { get; private set; }
        public int? Classificacao    { get; private set; }
        public string CNPJ           { get; private set; }
        public string IE             { get; private set; }
        public DateTime DataCriacao  { get; private set; }
        public int TipoObjeto        { get; private set; } = 3;
        public int IdUsuario         { get; set; }
        public int IdEndereco        {  get; private set; }
        public Endereco endereco       { get; set; }
    }
}
