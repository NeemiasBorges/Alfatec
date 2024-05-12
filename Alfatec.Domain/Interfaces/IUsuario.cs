using Alfatec.Domain.Entities;
using Alfatec.Domain.Interfaces.GenericInterfaces;

namespace Alfatec.Domain.Interfaces
{
    public interface IUsuario : AddEntitie<Usuario>, GetEntitie<Usuario>, UpdateEntitie<Usuario> , DesativarEntitie<Usuario>
    {
    }
}
