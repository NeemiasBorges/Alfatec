using Alfatec.Domain.Entities;

namespace Alfatec.Infra.Data.Repositories.Interface
{
    public interface IArquivoRepository
    {
        Task CriarArquivo(Arquivo novoArquivo);
        Task AtualizarArquivo(Arquivo arquivoAtualizado);
        List<Arquivo> BuscarArquivoPorIdUsuario(int idArquivo);
        Task RemoverArquivo(int idArquivo);
    }
}
