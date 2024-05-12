using Alfatec.Domain.Entities;
using Alfatec.Domain.Interfaces.GenericInterfaces;

namespace Alfatec.Domain.Interfaces
{
    public interface INoticiaRepository : AddEntitie<Noticia>, UpdateEntitie<Noticia>, GetEntitie<Noticia>, DesativarEntitie<Noticia>
    {
    }
}
