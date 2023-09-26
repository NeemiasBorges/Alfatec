using Alfatec.Domain.Entities;
using Alfatec.Domain.Interfaces.GenericInterfaces;

namespace Alfatec.Domain.Interfaces
{
    public interface IModoEnvio : AddEntitie<ModoEnvio>, UpdateEntitie<ModoEnvio>,DesativarEntitie<ModoEnvio>,GetEntitie<ModoEnvio>
    {
    }
}
