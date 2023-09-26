using Alfatec.Domain.Entities;
using Alfatec.Domain.Interfaces.GenericInterfaces;

namespace Alfatec.Domain.Interfaces
{
    public interface ISelo : AddEntitie<Selo>,DesativarEntitie<Selo>,UpdateEntitie<Selo>,GetEntitie<Selo>
    {

    }
}
