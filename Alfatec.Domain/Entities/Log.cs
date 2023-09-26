namespace Alfatec.Domain.Entities
{
    public class Log
    {
        public Log(int id, string nomeCampoAlterado, int usuario, string antigoValor, int tipoObjetoAlterado, string novoValor)
        {
            Id = id;
            NomeCampoAlterado = nomeCampoAlterado ?? throw new ArgumentNullException(nameof(nomeCampoAlterado));
            Usuario = usuario;
            AntigoValor = antigoValor ?? throw new ArgumentNullException(nameof(antigoValor));
            TipoObjetoAlterado = tipoObjetoAlterado;
            NovoValor = novoValor ?? throw new ArgumentNullException(nameof(novoValor));
        }

        public int Id { get; private set; }
        public string NomeCampoAlterado { get; private set; }
        public int Usuario { get; private set; }
        public string AntigoValor { get; private set; }
        public int TipoObjetoAlterado { get; private set; }
        public string NovoValor { get; private set; }
        public int TipoObjeto { get; private set; } = 13;
    }
}
