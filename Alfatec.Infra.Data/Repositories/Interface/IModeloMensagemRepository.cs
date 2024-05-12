using Alfatec.Domain.Entities;

namespace Alfatec.Infra.Data.Repositories.Interface
{
    public interface IModeloMensagemRepository
    {
        Task CriarModelo (ModeloMensagem modeloMensagem);
        Task AtualizarAutorizacao(ModeloMensagem modeloMensagem);
        Task<ModeloMensagem> GetModeloById(int ID);
    }
}
