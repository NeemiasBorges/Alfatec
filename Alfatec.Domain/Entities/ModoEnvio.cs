namespace Alfatec.Domain.Entities
{
    public class ModoEnvio
    {
        public ModoEnvio(int id, string nomeTransportadora, string cNPJTransportadora, string iETransportadora, string calculoPrevisaoEntrega, string tipoEnvio)
        {
            Id = id;
            NomeTransportadora = nomeTransportadora ?? throw new ArgumentNullException(nameof(nomeTransportadora));
            CNPJTransportadora = cNPJTransportadora ?? throw new ArgumentNullException(nameof(cNPJTransportadora));
            IETransportadora = iETransportadora ?? throw new ArgumentNullException(nameof(iETransportadora));
            CalculoPrevisaoEntrega = calculoPrevisaoEntrega ?? throw new ArgumentNullException(nameof(calculoPrevisaoEntrega));
            TipoEnvio = tipoEnvio ?? throw new ArgumentNullException(nameof(tipoEnvio));
        }

        public int Id { get; private set;}
        public string NomeTransportadora { get; private set;}
        public string CNPJTransportadora { get; private set;}
        public string IETransportadora { get; private set;}
        public string CalculoPrevisaoEntrega { get; private set;}
        public string TipoEnvio { get; private set;}
        public int TipoObjeto { get; private set; } = 12;
    }
}
