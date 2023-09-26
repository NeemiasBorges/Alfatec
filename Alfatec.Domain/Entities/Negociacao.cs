namespace Alfatec.Domain.Entities
{
    public class Negociacao
    {
        public Negociacao(int id, DateTime data, int iDEmpresaVendedora, int iDEmpresaCompradora, string metodoEnvio, string metodoPagamento, DateTime previsaoEntrega, string statusPagamento)
        {
            Id = id;
            Data = data;
            IDEmpresaVendedora = iDEmpresaVendedora;
            IDEmpresaCompradora = iDEmpresaCompradora;
            MetodoEnvio = metodoEnvio ?? throw new ArgumentNullException(nameof(metodoEnvio));
            MetodoPagamento = metodoPagamento ?? throw new ArgumentNullException(nameof(metodoPagamento));
            PrevisaoEntrega = previsaoEntrega;
            StatusPagamento = statusPagamento ?? throw new ArgumentNullException(nameof(statusPagamento));
        }

        public int Id { get; private set; }
        public DateTime Data { get; private set; }
        public int IDEmpresaVendedora { get; private set; }
        public Empresa EmpresaVendedora { get; private set; }
        public int IDEmpresaCompradora { get; private set; }
        public Empresa EmpresaCompradora { get; private set; }
        public int IDproduto { get; private set; }
        public Produto Produto { get; private set; }
        public string MetodoEnvio { get; private set; }
        public string MetodoPagamento { get; private set; }
        public DateTime PrevisaoEntrega { get; private set; }
        public string StatusPagamento { get; private set; }
        public int TipoObjeto { get; private set; } = 11;
}
}
