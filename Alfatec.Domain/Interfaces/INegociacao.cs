using Alfatec.Domain.Entities;
using Alfatec.Domain.Interfaces.GenericInterfaces;

namespace Alfatec.Domain.Interfaces
{
    public interface INegociacao : GetEntitie<Negociacao>, UpdateEntitie<Negociacao>, AddEntitie<Negociacao>
    {
        Task FinalizarNegociacao(int Id,string Status);   
    }
}
