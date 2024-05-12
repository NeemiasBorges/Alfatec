using Alfatec.Domain.Validations;

namespace Alfatec.Domain.Entities
{
    public class MidiaUsuario
    {
        public MidiaUsuario()
        {
        }
        public MidiaUsuario(int id, string nomeArquivo, string tipoArquivo, string diretorio, int tipoObjeto)
        {
            ValidateDomain(id, nomeArquivo, tipoArquivo, diretorio, tipoObjeto);

            Id = id;
            NomeArquivo = nomeArquivo;
            TipoArquivo = tipoArquivo;
            Diretorio = diretorio;
            TipoObjeto = tipoObjeto;
        }

        private void ValidateDomain(int id, string nomeArquivo, string tipoArquivo, string diretorio, int tipoObjeto)
        {
            DomainExceptionValidation.When(id <= 0, "ID inválido");
            DomainExceptionValidation.When(string.IsNullOrEmpty(nomeArquivo), "Nome do arquivo é obrigatório");
            DomainExceptionValidation.When(nomeArquivo.Length > 80, "Nome do arquivo deve ter no máximo 80 caracteres");
            DomainExceptionValidation.When(string.IsNullOrEmpty(tipoArquivo), "Tipo do arquivo é obrigatório");
            DomainExceptionValidation.When(tipoArquivo != "JPG", "Tipo de arquivo inválido. O valor válido é 'JPG'");
            DomainExceptionValidation.When(string.IsNullOrEmpty(diretorio), "Diretório é obrigatório");
        }

        public int Id { get; private set; }
        public string NomeArquivo { get; private set; }
        public string TipoArquivo { get; private set; }
        public string Diretorio { get; private set; }
        public int TipoObjeto { get; private set; } = 19;
    }
}
