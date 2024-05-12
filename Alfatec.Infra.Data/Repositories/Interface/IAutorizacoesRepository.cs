using Alfatec.Domain.Entities;

namespace Alfatec.Infra.Data.Repositories.Interface
{
    public interface IAutorizacoesRepository
    {
        Task CriarAutorizacao(Autorizacao auth);
        Task AtualizarAutorizacao(Autorizacao auth);
        Task BuscarAutorizacaoID(int ID);
        Task VerificarBloqueio(int IDuser);
    }
}
