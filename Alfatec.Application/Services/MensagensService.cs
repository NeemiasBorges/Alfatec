using Alfatec.Application.DTOs;
using Alfatec.Application.Services.Interfaces;
using Alfatec.Domain.Entities;
using Alfatec.Infra.Data.Repositories.Interface;
using AutoMapper;

namespace Alfatec.Application.Services
{
    public class MensagensService : IMensagensService
    {
        private readonly IMensagemRepository _mensagemRepository;
        private readonly IMapper _mapper;

        public MensagensService(IMensagemRepository mensagemRepository, IMapper mapper)
        {

            _mensagemRepository = mensagemRepository;
            _mapper = mapper;
        }
        public async Task Add(MensagemDTO obj)
        {
            try
            {
                var entittyOBJ = _mapper.Map<Mensagem>(obj);
                await _mensagemRepository.adicionarMensagem(entittyOBJ);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }        
        }

        public async Task addMessage(int idModelo, string texto)
        {
            throw new NotImplementedException();
        }

        public async Task<MensagemDTO> GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<MensagemDTO>> list()
        {
            throw new NotImplementedException();
        }

        public async Task Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
