using Alfatec.Domain.Entities;
using Alfatec.Domain.Interfaces.GenericInterfaces;

namespace Alfatec.Domain.Interfaces
{
    public interface IEnderecos : AddEntitie<Endereco>, UpdateEntitie<Endereco>, DesativarEntitie<Endereco>,GetEntitie<Endereco>
    {
        Task<Endereco> GetEnderecoByEmpresaID(int empresaId);
    }
}
