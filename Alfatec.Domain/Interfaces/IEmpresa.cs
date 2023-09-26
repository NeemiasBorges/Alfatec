using Alfatec.Domain.Entities;
using Alfatec.Domain.Interfaces.GenericInterfaces;

namespace Alfatec.Domain.Interfaces
{
    public interface IEmpresa : AddEntitie<Empresa>,  DesativarEntitie<Empresa>, UpdateEntitie<Empresa>, GetEntitie<Empresa>
    {
    }
}
