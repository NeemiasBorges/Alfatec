using Alfatec.Domain.Entities;
using Alfatec.Infra.Data.Context;
using Alfatec.Infra.Data.Repositories.Interface;
using Alfatec.Infra.Data.Repositories.Interface.GenericInterfaces;

namespace Alfatec.Infra.Data.Repositories
{
    public class NoticiaRepository : INoticiaRepository
    {
        ApplicationDbContext _context;
        public NoticiaRepository(ApplicationDbContext context)
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

        public List<Noticia> listAll()
        {
            return _context.Noticia.ToList();
        }

        async Task<List<Noticia>> IComumActions<Noticia>.listAll()
        {
            throw new NotImplementedException();
        }
    }
}
