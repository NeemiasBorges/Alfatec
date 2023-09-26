using Alfatec.Domain.Entities;
using Alfatec.Domain.Interfaces.GenericInterfaces;

namespace Alfatec.Domain.Interfaces
{
    public interface IMidiaUsuario : AddEntitie<MidiaUsuario>, UpdateEntitie<MidiaUsuario>, RemoveEntitie<MidiaUsuario>, GetEntitie<MidiaUsuario>
    {
        Task<MidiaUsuario> GetByUsuarioId();
    }
}
