using Alfatec.Application.DTOs;
using Alfatec.Application.Services.Interfaces;
using Alfatec.Infra.Data.Repositories.Interface;
using AutoMapper;

namespace Alfatec.Application.Services
{
    public class ServicoService : IServicoService
    {
        private readonly IServicoRepository _repository;
        private readonly IMapper _mapper;
        public ServicoService(IMapper mapper, IServicoRepository srv)
        {
            _repository = srv;
            _mapper = mapper;
        }

        public async Task Add(ServicosDTO obj)
        {
            throw new NotImplementedException();
        }

        public async Task<ServicosDTO> GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ServicosDTO>> list()
        {
            try
            {
                var srvcs = await _repository.listAll();
                return _mapper.Map<List<ServicosDTO>>(srvcs);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
