using Alfatec.Domain.Entities;

namespace Alfatec.Infra.Data.Repositories.Interface
{
    public interface ISeloRepository
    {
        Task CriarSelo(Selo novoSelo);
        Task AtualizarSelo(Selo seloAtualizado);
        Task<Selo> BuscarSeloPorId(int idSelo);
        Task<List<Selo>> ListarTodosSelos();
        Task RemoverSelo(int idSelo);
    }
}
