using Alfatec.Domain.Entities;
using Alfatec.Domain.Interfaces.GenericInterfaces;

namespace Alfatec.Domain.Interfaces
{
    public interface IProduto : AddEntitie<Produto>, UpdateEntitie<Produto>, DesativarEntitie<Produto>,GetEntitie<Produto>
    {
        Task<ICollection<Produto>> Filtrar(
            string nome = "",
            string categori= "",   
            string validade = "",
            string empresa = "",
            string caracteristica = ""
            );
    }
}
