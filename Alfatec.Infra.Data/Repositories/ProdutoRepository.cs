using Alfatec.Domain.Entities;
using Alfatec.Infra.Data.Context;
using Alfatec.Infra.Data.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Alfatec.Infra.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        ApplicationDbContext _context;
        public ProdutoRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AtualizarProduto(Produto Atualizado)
        {
            throw new NotImplementedException();
        }

        public async Task BloquearProduto(int idProduto)
        {
            throw new NotImplementedException();
        }

        public Produto BuscarProdutoPorId(int idProduto)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Produto>> BuscarProdutosPorNome(string nomeProduto)
        {
            throw new NotImplementedException();
        }

        public async Task CriarProduto(Produto novoProduto)
        {
            throw new NotImplementedException();
        }

        public async Task DesbloquearProduto(int idProduto)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Produto>> ListarTodosProdutos()
        {
            return await _context.Produto.ToListAsync();
        }

        public async Task RemoverProduto(int idProduto)
        {
            throw new NotImplementedException();
        }
    }
}
