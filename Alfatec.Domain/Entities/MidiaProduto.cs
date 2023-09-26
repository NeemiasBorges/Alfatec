namespace Alfatec.Domain.Entities
{
    public class MidiaProduto
    {
        public MidiaProduto(int id, int idproduto, string nome, string tipoArquivo, string diretorio)
        {
            Id = id;
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            TipoArquivo = tipoArquivo ?? throw new ArgumentNullException(nameof(tipoArquivo));
            Diretorio = diretorio ?? throw new ArgumentNullException(nameof(diretorio));
            IDproduto = idproduto;
        }

        public int Id { get; private set; }
        public int IDproduto { get; private set; }
        public Produto Produto { get; private set; }
       public string Nome  { get; private set; }
       public string TipoArquivo { get; private set; }
       public string Diretorio { get; private set; }
       public int TipoObjeto { get; private set; } = 9;
    }
}
