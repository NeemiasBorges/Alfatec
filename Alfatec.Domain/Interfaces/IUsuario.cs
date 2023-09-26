using Alfatec.Domain.Entities;
using Alfatec.Domain.Interfaces.GenericInterfaces;

namespace Alfatec.Domain.Interfaces
{
    public interface IUsuario : AddEntitie<Usuarios>, GetEntitie<Usuarios>, UpdateEntitie<Usuarios> , DesativarEntitie<Usuarios>
    {
    }
}
