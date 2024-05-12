using Alfatec.Domain.Entities;
using Alfatec.Domain.Interfaces;

namespace Alfatec.Domain
{
    public class CategoriaRepository : ICategoriaRepository
    {
        public Task Add(Categoria entitie)
        {
            throw new NotImplementedException();
        }

        public Task DesativarByID(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Categoria>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Categoria> GetById(Categoria entitie)
        {
            throw new NotImplementedException();
        }

        public Task<Categoria> GetByID(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
