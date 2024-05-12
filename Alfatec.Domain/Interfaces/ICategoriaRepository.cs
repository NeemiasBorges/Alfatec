using Alfatec.Domain.Entities;
using Alfatec.Domain.Interfaces.GenericInterfaces;

namespace Alfatec.Domain.Interfaces
{
    public interface ICategoriaRepository :  AddEntitie<Categoria>, UpdateEntitie<Categoria>, GetEntitie<Categoria>, DesativarEntitie<Categoria>
    {
    }
}
