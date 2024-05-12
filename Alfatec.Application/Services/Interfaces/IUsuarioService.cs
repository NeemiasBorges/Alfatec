using Alfatec.Application.DTOs;
using Alfatec.Application.Enum;
using Alfatec.Application.Services.Interfaces.Generic;

namespace Alfatec.Application.Services.Interfaces
{
    public interface IUsuarioService : CRUDInterface<UsuarioDTO>
    {
        Task<string> GeneratePassword();
        Task addInSendMessage(MessageTypes messageType, UsuarioDTO usuario);
        Task<UsuarioDTO> login(string email, string password);
        Task<bool> logout();
        Task<bool> logoutConfirmed()
            => throw new NotImplementedException();
    }
}
