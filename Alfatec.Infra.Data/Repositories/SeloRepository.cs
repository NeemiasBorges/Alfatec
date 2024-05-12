using Alfatec.Domain.Entities;
using Alfatec.Infra.Data.Context;
using Alfatec.Infra.Data.Repositories.Interface;

namespace Alfatec.Infra.Data.Repositories
{
    public class SeloRepository : ISeloRepository
    {
        ApplicationDbContext _context;
        public SeloRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AtualizarSelo(Selo seloAtualizado)
        {
            throw new NotImplementedException();
        }

        public async Task<Selo> BuscarSeloPorId(int idSelo)
        {
            throw new NotImplementedException();
        }

        public async Task CriarSelo(Selo novoSelo)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Selo>> ListarTodosSelos()
        {
            return _context.Selo.ToList();
        }

        public async Task RemoverSelo(int idSelo)
        {
            throw new NotImplementedException();
        }
    }
}
