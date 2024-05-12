using Alfatec.Domain.Entities;

namespace Alfatec.Infra.Data.Repositories.Interface
{
    public interface ICategoriaRepository
    {
        Task CriarCategoria(Categoria novaCategoria);
        Task AtualizarCategoria(Categoria categoriaAtualizada);
        Task<Categoria> BuscarCategoriaPorId(int idCategoria);
        Task<List<Categoria>> ListarTodasCategorias();
        Task RemoverCategoria(int idCategoria);
    }
}
