using Alfatec.Application.DTOs;
using Alfatec.Application.Services.Interfaces.Generic;

namespace Alfatec.Application.Services.Interfaces
{
    public interface IEnderecoService : CRUDInterface<EnderecoDTO>
    {
       public Task addCondicaoVia(CondicoesDTO condicao);
       public Task<List<CondicoesDTO>> listaCondicoes();

    }
}
