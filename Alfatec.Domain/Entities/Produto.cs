namespace Alfatec.Domain.Entities
{
    public class Produto
    {
        public Produto(int id, string nomeProduto, string descricaoProduto, 
            string status, int idcategoria, string unidadeVenda, int midiaprodutos, string variacao, string validade, 
            string classificacao, DateTime dataCriacao)
        {
            Id = id;
            NomeProduto = nomeProduto ?? throw new ArgumentNullException(nameof(nomeProduto));
            DescricaoProduto = descricaoProduto ?? throw new ArgumentNullException(nameof(descricaoProduto));
            Status = status ?? throw new ArgumentNullException(nameof(status));
            IDCategoria = idcategoria;
            UnidadeVenda = unidadeVenda ?? throw new ArgumentNullException(nameof(unidadeVenda));
            IdMidiaProdutos = midiaprodutos;
            Variacao = variacao ?? throw new ArgumentNullException(nameof(variacao));
            Validade = validade ?? throw new ArgumentNullException(nameof(validade));
            Classificacao = classificacao ?? throw new ArgumentNullException(nameof(classificacao));
            DataCriacao = dataCriacao;
        }

        public int Id { get; private set; }
        public string NomeProduto { get; private set; }
        public string DescricaoProduto { get; private set; }
        public string Status { get; private set; }
        public int IDCategoria { get; private set; }
        public Categoria Categoria { get; private set; }
        public string UnidadeVenda { get; private set; }
        public int IdMidiaProdutos { get; private set; }
        public string Variacao { get; private set; }
        public string Validade { get; private set; }
        public ICollection<Selo> Selos { get; private set; }
        public string Classificacao { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public int TipoObjeto { get; private set; } = 4;
        public ICollection<Comentario> Comentarios { get; set; }
        public ICollection<MidiaProduto> MidiaProdutos{ get; set; }
    }
}
