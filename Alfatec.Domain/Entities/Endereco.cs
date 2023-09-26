namespace Alfatec.Domain.Entities
{
    public class Endereco
    {
        public Endereco(int id, string nome, string rua, string bairro, string cEP, string complemento, string uF, string observacoes)
        {
            Id = id;
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Rua = rua ?? throw new ArgumentNullException(nameof(rua));
            Bairro = bairro ?? throw new ArgumentNullException(nameof(bairro));
            CEP = cEP ?? throw new ArgumentNullException(nameof(cEP));
            Complemento = complemento ?? throw new ArgumentNullException(nameof(complemento));
            UF = uF ?? throw new ArgumentNullException(nameof(uF));
            Observacoes = observacoes ?? throw new ArgumentNullException(nameof(observacoes));
        }

        public int Id { get ; private set ;}
        public string Nome { get ; private set ;}
        public string Rua { get ; private set ;}
        public string Bairro { get ; private set ;}
        public string CEP { get ; private set ;}
        public string Complemento { get ; private set ;}
        public string UF { get ; private set ;}
        public string Observacoes { get ; private set ;}
        public int TipoObjeto { get; private set; } = 8;
    }
}
