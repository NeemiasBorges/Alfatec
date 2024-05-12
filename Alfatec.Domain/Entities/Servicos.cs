
namespace Alfatec.Domain.Entities
{
    public class Servicos
    {
        public Servicos(){}

        public Servicos(int id, string nomeServico, string descricao) : this(id, nomeServico)
        {
            Descricao = descricao ?? throw new ArgumentNullException(nameof(descricao));
        }

        public Servicos(int id, string nomeServico)
        {
            Id = id;
            NomeServico = nomeServico ?? throw new ArgumentNullException(nameof(nomeServico));
        }

        public int Id { get; set; }
        public string NomeServico { get; set; }
        public string Descricao { get; set; }
        public int TipoObjeto { get; set; } = 23;
    }
}
