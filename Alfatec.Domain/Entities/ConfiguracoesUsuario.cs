namespace Alfatec.Domain.Entities
{
    public class ConfiguracoesUsuario
    {
        public ConfiguracoesUsuario(){}

        public ConfiguracoesUsuario(int id, string nomeconfiguracao)
        {
            Id = id;
            nomeConfiguracao = nomeconfiguracao;
        }
        public int Id                  { get; private set; }
        public string nomeConfiguracao { get; private set; }
        public int TipoObjeto { get; private set; } = 17;
    }
}
