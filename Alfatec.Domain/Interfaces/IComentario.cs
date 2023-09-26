using Alfatec.Domain.Entities;
using Alfatec.Domain.Interfaces.GenericInterfaces;

namespace Alfatec.Domain.Interfaces
{
    public interface IComentario : AddEntitie<Comentario>, UpdateEntitie<Comentario>, DesativarEntitie<Comentario>, GetEntitie<Comentario>
    {
    }
}
