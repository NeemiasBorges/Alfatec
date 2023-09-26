namespace Alfatec.Domain.Entities
{
    public class Selo
    {
        public Selo(int id, string nome, DateTime dataCriacao, int tipoObjeto)
        {
            Id = id;
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            DataCriacao = dataCriacao;
            TipoObjeto = tipoObjeto;
        }

        public int Id { get; private set ; }
        public string Nome  { get; private set ; }
        public DateTime DataCriacao { get; private set ; }
        public int TipoObjeto { get; private set; } = 7;
    }
}
