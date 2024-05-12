using Alfatec.Domain.Entities;
using Alfatec.Infra.Data.Context;
using Alfatec.Infra.Data.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Alfatec.Infra.Data.Repositories
{
    public class ServicosRepository : IServicoRepository
    {
        ApplicationDbContext _context;
        public ServicosRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Add(Mensagem mensagem)
        {
            throw new NotImplementedException();
        }

        public async Task Att(Mensagem mensagem)
        {
            throw new NotImplementedException();
        }

        public async Task Dele(int id)
        {
            throw new NotImplementedException();
        }

        public Mensagem FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Servicos>> listAll()
        {
            return await _context.Servicos.ToListAsync();
        }
    }
}
