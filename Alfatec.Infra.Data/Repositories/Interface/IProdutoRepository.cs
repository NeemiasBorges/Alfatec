using Alfatec.Domain.Entities;

namespace Alfatec.Infra.Data.Repositories.Interface
{
    public interface IProdutoRepository
    {
        Task CriarProduto(Produto novoProduto);
        Task AtualizarProduto(Produto Atualizado);
        Produto BuscarProdutoPorId(int idProduto);
        Task<List<Produto>> BuscarProdutosPorNome(string nomeProduto);
        Task<List<Produto>> ListarTodosProdutos();
        Task RemoverProduto(int idProduto);
        Task BloquearProduto(int idProduto);
        Task DesbloquearProduto(int idProduto);
    }
}
