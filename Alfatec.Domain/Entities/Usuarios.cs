using Alfatec.Domain.Validations;

namespace Alfatec.Domain.Entities
{
    public class Usuario
    {
        public Usuario(){}
        public Usuario(int id, string nome, string tipo, string email, string nomeEmpresa, string senha, int idAutorizacao, int idMidiaUsuario, int ddd, string telefone,string cNPJ = "")
        {
            ValidateDomain(id, nome, tipo, email, nomeEmpresa, senha, idAutorizacao, idMidiaUsuario, ddd, telefone);

            Id = id;
            Nome = nome;
            Tipo = tipo;
            Email = email;
            NomeEmpresa = nomeEmpresa;
            Senha = senha;
            IdAutorizacao = idAutorizacao;
            IdMidiaUsuario = idMidiaUsuario;
            DDD = ddd;
            Telefone = telefone;
            CNPJ = cNPJ.Replace(".","").Replace("-","").Replace("/", "");
        }

        public Usuario(string email, string senha)
        {
            ValidateDomain(email, senha);

            Email = email;
            Senha = senha;
        }

        private void ValidateDomain(int id, string nome, string tipo, string email, string nomeEmpresa, string senha, int idAutorizacao, int idMidiaUsuario, int ddd, string telefone)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "Nome é obrigatório");
            DomainExceptionValidation.When(nome.Length > 25, "Nome deve ter no máximo 25 caracteres");
            DomainExceptionValidation.When(string.IsNullOrEmpty(tipo), "Tipo é obrigatório");
            DomainExceptionValidation.When(tipo.Length > 4, "Tipo deve ter no máximo 3 caractere");
            //DomainExceptionValidation.When(tipo != "USR" && tipo != "ADM", "Tipo inválido. Os valores válidos são 'USR' ou 'ADM'");
            //DomainExceptionValidation.When(string.IsNullOrEmpty(email), "Email é obrigatório");
            //DomainExceptionValidation.When(!email.Contains("@"), "Email inválido");
            //DomainExceptionValidation.When(string.IsNullOrEmpty(nomeEmpresa), "Nome da empresa é obrigatório");
            //DomainExceptionValidation.When(nomeEmpresa.Length > 50, "Nome da empresa deve ter no máximo 50 caracteres");
            //DomainExceptionValidation.When(string.IsNullOrEmpty(senha), "Senha é obrigatória");
            //DomainExceptionValidation.When(senha.Length < 8 || senha.Length > 16, "Senha deve ter entre 8 e 16 caracteres");
            //DomainExceptionValidation.When(idEmpresa <= 0, "ID da empresa é obrigatório");
        }

        private void ValidateDomain(string email, string senha)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(email), "Email é obrigatório");
            DomainExceptionValidation.When(!email.Contains("@"), "Email inválido");
            DomainExceptionValidation.When(string.IsNullOrEmpty(senha), "Senha é obrigatória");
            DomainExceptionValidation.When(senha.Length < 8 || senha.Length > 16, "Senha deve ter entre 8 e 16 caracteres");
        }

        public int Id                    { get; set; }
        public string Nome               { get; set; }
        public string Tipo               { get; private set; }
        public string Email              { get; set; }
        public string NomeEmpresa        { get; private set; }
        public string Senha              { get; private set; }
        public int IdEndereco             { get; private set; }
        public int IdAutorizacao         { get; private set; }
        public int IdMidiaUsuario        { get; private set; }
        public int DDD                   { get; private set; }
        public string Telefone           { get; private set; }
        public int TipoObjeto            { get; private set; } = 1;
        public string CNPJ               { get; private set; }
        public Endereco Endereco          { get; private set; }
    }
}
