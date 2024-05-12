using Alfatec.Application.DTOs;
using Alfatec.Application.Services.Interfaces.Generic;

namespace Alfatec.Application.Services.Interfaces
{
    public interface IProdutoService : CRUDInterface<ProdutoDTO>
    {
        Task Comprar(DateTime dataEntrega, string horarioentrega);
    }
}
