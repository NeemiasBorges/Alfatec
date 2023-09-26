using Alfatec.Domain.Entities;
using Alfatec.Domain.Interfaces.GenericInterfaces;

namespace Alfatec.Domain.Interfaces
{
    public interface ILogs : AddEntitie<Log>, GetEntitie<Log>
    {
    }
}
