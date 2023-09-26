using Alfatec.Domain.Entities;
using Alfatec.Domain.Interfaces.GenericInterfaces;

namespace Alfatec.Domain.Interfaces
{
    public interface IMidiaProduto : AddEntitie<MidiaProduto>,UpdateEntitie<MidiaProduto>,RemoveEntitie<MidiaProduto>,GetEntitie<MidiaProduto>
    {
        Task<MidiaProduto> GetByProdutoID(int id);
    }
}
