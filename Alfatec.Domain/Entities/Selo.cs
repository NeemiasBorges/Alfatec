using Alfatec.Domain.Validations;

namespace Alfatec.Domain.Entities
{
    public class Selo
    {
        public Selo(){}
        public Selo(int id, string nomeSelo, DateTime dataCriacao, int tipoObjeto)
        {
            ValidateDomain(id, nomeSelo, dataCriacao, tipoObjeto);

            Id = id;
            NomeSelo = nomeSelo;
            DataCriacao = dataCriacao;
            TipoObjeto = tipoObjeto;
        }

        private void ValidateDomain(int id, string nomeSelo, DateTime dataCriacao, int tipoObjeto)
        {
            DomainExceptionValidation.When(id <= 0, "ID inválido");
            DomainExceptionValidation.When(string.IsNullOrEmpty(nomeSelo), "Nome do selo é obrigatório");
            DomainExceptionValidation.When(nomeSelo.Length > 30, "Nome do selo deve ter no máximo 30 caracteres");
        }

        public int Id { get; set; }
        public string NomeSelo { get;  set; }
        public DateTime DataCriacao { get;  set; }
        public int TipoObjeto { get;  set; } = 8;
    }
}
