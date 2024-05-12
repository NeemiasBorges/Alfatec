using Alfatec.Domain.Interfaces;
using Alfatec.Infra.Data.Context;

namespace Alfatec.Infra.Data.Repositories
{
    public class EmpresaRepository : IEmpresa
    {
        ApplicationDbContext _context;
        public EmpresaRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Add(Domain.Entities.Empresa entitie)
        {
            throw new NotImplementedException();
        }

        public async Task DesativarByID(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Domain.Entities.Empresa>> Get()
        {
            throw new NotImplementedException();
        }

        public async Task<Domain.Entities.Empresa> GetById(Domain.Entities.Empresa entitie)
        {
            throw new NotImplementedException();
        }

        public async Task<Domain.Entities.Empresa> GetByID(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
