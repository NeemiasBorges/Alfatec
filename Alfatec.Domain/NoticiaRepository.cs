using Alfatec.Domain.Entities;
using Alfatec.Domain.Interfaces;

namespace Alfatec.Domain
{
    public class NoticiaRepository : INoticiaRepository
    {
        public async Task Add(Noticia entitie)
        {
            throw new NotImplementedException();
        }

        public async Task DesativarByID(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Noticia>> Get()
        {
            throw new NotImplementedException();
        }

        public async Task<Noticia> GetById(Noticia entitie)
        {
            throw new NotImplementedException();
        }

        public async Task<Noticia> GetByID(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
