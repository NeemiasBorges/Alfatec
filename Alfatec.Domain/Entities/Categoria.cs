using Alfatec.Domain.Validations;

namespace Alfatec.Domain.Entities
{
    public class Categoria
    {
        public Categoria()
        {
        }
        public Categoria(int id, string nomeCategoria, DateTime dataCriacao, int tipoObjeto)
        {
            ValidateDomain(id, nomeCategoria, dataCriacao, tipoObjeto);

            Id = id;
            NomeCategoria = nomeCategoria;
            DataCriacao = dataCriacao;
            TipoObjeto = tipoObjeto;
        }

        private void ValidateDomain(int id, string nomeCategoria, DateTime dataCriacao, int tipoObjeto)
        {
            DomainExceptionValidation.When(id <= 0, "ID inválido");
            DomainExceptionValidation.When(string.IsNullOrEmpty(nomeCategoria), "Nome da categoria é obrigatório");
            DomainExceptionValidation.When(nomeCategoria.Length > 50, "Nome da categoria deve ter no máximo 50 caracteres");
        }

        public int Id { get;  set; }
        public string NomeCategoria { get;  set; }
        public DateTime DataCriacao { get;  set; }
        public int TipoObjeto { get; set; } = 7;

    }
}
