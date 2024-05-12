namespace Alfatec.Domain.Entities
{
    public class CondicoesEstrada
    {
        public CondicoesEstrada(){}
        public CondicoesEstrada(int id, string localizacao, DateTime dataRegistro, string observacoes)
        {
            Id = id;
            Localizacao = localizacao ?? throw new ArgumentNullException(nameof(localizacao));
            DataRegistro = dataRegistro;
            Observacoes = observacoes ?? throw new ArgumentNullException(nameof(observacoes));
        }

        public int Id { get; set; }
        public string Localizacao { get; set; }
        public DateTime DataRegistro { get; set; }
        public string Observacoes { get; set; }
        public int TipoObjeto { get; private set; } = 16;
    }
}
