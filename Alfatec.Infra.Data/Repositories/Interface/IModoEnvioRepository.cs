using Alfatec.Domain.Entities;

namespace Alfatec.Infra.Data.Repositories.Interface
{
    public interface IModoEnvioRepository
    {
        Task AtualizarNegociação(Negociacao negociacaoAtualizada);
        Task<Negociacao> BuscarNegociacaoPorId(int idNegociação);
        List<Negociacao> ListarTodasNegociações();
    }
}
