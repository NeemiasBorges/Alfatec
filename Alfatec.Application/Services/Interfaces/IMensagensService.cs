using Alfatec.Application.DTOs;
using Alfatec.Application.Services.Interfaces.Generic;

namespace Alfatec.Application.Services.Interfaces
{
    public interface IMensagensService : CRUDInterface<MensagemDTO>
    {
        Task addMessage(int idModelo,string texto);
    }
}
