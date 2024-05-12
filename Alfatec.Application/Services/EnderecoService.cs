using Alfatec.Application.DTOs;
using Alfatec.Application.Services.Interfaces;
using Alfatec.Infra.Data.Repositories.Interface;
using AutoMapper;

namespace Alfatec.Application.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IEnderecoRepository _repository;
        private readonly IMapper _mapper;
        public EnderecoService(IEnderecoRepository repositorio, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repositorio;
        }
        public async Task Add(EnderecoDTO obj)
        {
            throw new NotImplementedException();
        }

        public async Task addCondicaoVia(CondicoesDTO condicao)
        {
            throw new NotImplementedException();
        }

        public async Task<EnderecoDTO> GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<EnderecoDTO>> list()
        {
            throw new NotImplementedException();
        }

        public async Task<List<CondicoesDTO>> listaCondicoes()
        {
            var condicoes = await _repository.listaCondicoes();
            var entittyOBJ = _mapper.Map<List<CondicoesDTO>>(condicoes);
            return entittyOBJ;
        }

        public async Task Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
