using Alfatec.Domain.Validations;

namespace Alfatec.Domain.Entities
{
    public class Usuarios
    {
        public Usuarios(int id, string nome,string cortemaempresa, string tipo, string email, string nomeEmpresa, string senha, int iDEmpresa, int idAutorizacao, int iDMidiaUsuario, string cargo, int dDD, string telefone, int tipoObjeto)
        {
            Id = id;
            Nome = nome;
            CorTemaEmpresa = cortemaempresa;
            Tipo = tipo;
            Email = email;
            NomeEmpresa = nomeEmpresa;
            Senha = senha;
            IDEmpresa = iDEmpresa;
            IdAutorizacao = idAutorizacao;
            IDMidiaUsuario = iDMidiaUsuario;
            Cargo = cargo;
            DDD = dDD;
            Telefone = telefone;
            TipoObjeto = tipoObjeto;
        }

        public Usuarios(string email, string senha)
        {
            ValidateDomain(email,senha);
        }
        public Usuarios(int id, string email, string senha,int idEmpresa)
        {
            ValidateDomain(id,email,senha,idEmpresa);
        }

        private void ValidateDomain(int id, string email, string senha, int idEmpresa)
        {
            DomainExceptionValidation.When(idEmpresa == null, "Empresa Obrigatória");
            DomainExceptionValidation.When(id == null, "ID Invalido");
            DomainExceptionValidation.When(String.IsNullOrEmpty(email), "Email obrigatorio");
            DomainExceptionValidation.When(String.IsNullOrEmpty(senha), "Senha obrigatoria");
            DomainExceptionValidation.When(!email.Contains("@"), "Email inválido");
            DomainExceptionValidation.When(senha.Length < 8, "Senha muito curta");

            Email = email;
            Senha = senha;
            Id =  id;
            Senha =  senha;
            IDEmpresa = idEmpresa;
        }

        private void ValidateDomain(string email, string senha)
        {
            DomainExceptionValidation.When(String.IsNullOrEmpty(email), "Email obrigatorio");
            DomainExceptionValidation.When(String.IsNullOrEmpty(senha), "Senha obrigatoria");
            DomainExceptionValidation.When(!email.Contains("@"), "Email inválido");
            DomainExceptionValidation.When(senha.Length < 8, "Senha muito curta");

            Email = email;
            Senha = senha;
        }

       public int Id { get; private set; }
       public string Nome { get; private set; }
       public string CorTemaEmpresa { get; private set; }
       public string Tipo { get; private set; }
       public string Email { get; private set; }
       public string NomeEmpresa { get; private set; }
       public string Senha { get; private set; }
       public int? IDEmpresa { get; private set; }
       public int? IdAutorizacao { get; private set; }
       public int? IDMidiaUsuario { get; private set; }
       public string Cargo { get; private set; }
       public int DDD { get; private set; }
       public string Telefone { get; private set; }
       public int TipoObjeto { get; private set; } = 1;

        public MidiaUsuario MidiaUsuario { get; set; }
        public Autorizacoes Autorizacoes { get; set; }
        public Empresa Empresa { get; set; }

    }
}
