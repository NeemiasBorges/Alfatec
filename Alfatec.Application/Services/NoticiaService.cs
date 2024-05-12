using Alfatec.Application.DTOs;
using Alfatec.Application.Services.Interfaces;
using Alfatec.Domain.Interfaces;
using AutoMapper;

namespace Alfatec.Application.Services
{
    public class NoticiaService : INoticiaService
    {
        private  INoticiaRepository _repository;
        private  IMapper _mapper;
        public NoticiaService(IMapper mapper, INoticiaRepository noticiaRepository)
        {
            _repository = noticiaRepository;
            _mapper = mapper;
        }
        public async Task Add(NoticiaDTO obj)
        {
            throw new NotImplementedException();
        }

        public async Task<NoticiaDTO> GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<NoticiaDTO>> list()
        {
            try
            {
                var noticias = await _repository.Get();
                return _mapper.Map<List<NoticiaDTO>>(noticias);
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
