namespace Alfatec.Domain.Entities
{
    public class VeiculoUsuario
    {
        public VeiculoUsuario(){}
        public VeiculoUsuario(int id, string marca, string modelo, int ano, string placa, string cor, string tipoCombustivel, double capacidadeTanque, DateTime dataUltimaManutencao, string observacoes, int usuarioId, int veiculoId)
        {
            Id                   = id;
            Marca                = marca;
            Modelo               = modelo;
            Ano                  = ano;
            Placa                = placa;
            Cor                  = cor;
            TipoCombustivel      = tipoCombustivel;
            CapacidadeTanque     = capacidadeTanque;
            DataUltimaManutencao = dataUltimaManutencao;
            Observacoes          = observacoes;
            UsuarioId            = usuarioId;
            VeiculoId            = veiculoId;
        }

        public int Id { get; private set; }
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public int Ano { get; private set; }
        public string Placa { get; private set; }
        public string Cor { get; private set; }
        public string TipoCombustivel { get; private set; }
        public double CapacidadeTanque { get; private set; }
        public DateTime DataUltimaManutencao { get; private set; }
        public string Observacoes { get; private set; }
        public Usuario Usuario { get; private set; } 
        public int UsuarioId { get; private set; } 
        public Veiculo Veiculo { get; private set; } 
        public int VeiculoId { get; private set; }
        public int TipoObjeto { get; private set; } = 22;
    }
}
