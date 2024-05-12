using Alfatec.Domain.Entities;

namespace Alfatec.Infra.Data.Repositories.Interface
{
    public interface IMensagemRepository
    {
        Task adicionarMensagem(Mensagem mensagem);
        Mensagem encontrarMensagemPorId(int id);
        List<Mensagem> listarTodasAsMensagens();
        Task atualizarMensagem(Mensagem mensagem);
        Task deletarMensagem(int id);
    }
}
