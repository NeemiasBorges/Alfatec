using Alfatec.Domain.Entities;
using Alfatec.Domain.Interfaces.GenericInterfaces;


namespace Alfatec.Domain.Interfaces
{
    public interface IAutorizacoes : AddEntitie<Autorizacoes>, UpdateEntitie<Autorizacoes>, GetEntitie<Autorizacoes>
    {
    }
}
