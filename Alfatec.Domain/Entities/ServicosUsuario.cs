
namespace Alfatec.Domain.Entities
{
    public class ServicosUsuario
    {
        public ServicosUsuario(){}
        public ServicosUsuario(int id, string nomeServico, string descricao)
        {
            Id = id;
            NomeServico = nomeServico ?? throw new ArgumentNullException(nameof(nomeServico));
            Descricao = descricao ?? throw new ArgumentNullException(nameof(descricao));
        }
        public ServicosUsuario(int id, int idUsuario, Usuario usuario, int idServico, Servicos servico, string nomeServico, string descricao)
        {
            Id = id;
            IdUsuario = idUsuario;
            Usuario = usuario ?? throw new ArgumentNullException(nameof(usuario));
            IdServico = idServico;
            Servico = servico ?? throw new ArgumentNullException(nameof(servico));
            NomeServico = nomeServico ?? throw new ArgumentNullException(nameof(nomeServico));
            Descricao = descricao ?? throw new ArgumentNullException(nameof(descricao));
        }

        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }
        public int IdServico { get; set; }
        public Servicos Servico { get; set; }
        public string NomeServico { get; set; }
        public string Descricao { get; set; }
        public int TipoObjeto { get; set; } = 24;
    }
}
