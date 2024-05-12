using Alfatec.Application.DTOs;
using Alfatec.Application.Services.Interfaces;
using Alfatec.Infra.Data.Repositories.Interface;
using AutoMapper;

namespace Alfatec.Application.Services
{
    public class SeloService : ISeloService
    {
        private readonly ISeloRepository _repository;
        private readonly IMapper _mapper;
        public SeloService(IMapper mapper, ISeloRepository selo)
        {
            _repository = selo;
            _mapper = mapper;
        }
        public async Task Add(SeloDTO obj)
        {
            throw new NotImplementedException();
        }

        public async Task<SeloDTO> GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SeloDTO>> list()
        {
            try
            {
                var selos = await _repository.ListarTodosSelos();
                return _mapper.Map<List<SeloDTO>>(selos);
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
