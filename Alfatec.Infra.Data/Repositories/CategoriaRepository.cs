using Alfatec.Domain.Entities;
using Alfatec.Infra.Data.Context;
using Alfatec.Infra.Data.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Alfatec.Infra.Data.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        ApplicationDbContext _context;
        public CategoriaRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AtualizarCategoria(Categoria categoriaAtualizada)
        {
            _context.Categoria.Update(categoriaAtualizada);
        }

        public async Task<Categoria> BuscarCategoriaPorId(int idCategoria)
        {
            throw new NotImplementedException();
        }

        public async Task CriarCategoria(Categoria novaCategoria)
        {
            _context.Categoria.Add(novaCategoria);
        }

        public async Task<List<Categoria>> ListarTodasCategorias()
        {
            return await _context.Categoria.ToListAsync();
        }

        public async Task RemoverCategoria(int idCategoria)
        {
            throw new NotImplementedException();
        }
    }
}
