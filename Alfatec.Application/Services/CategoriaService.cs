using Alfatec.Application.DTOs;
using Alfatec.Application.Services.Interfaces;
using Alfatec.Infra.Data.Repositories.Interface;
using AutoMapper;

namespace Alfatec.Application.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _repository;
        private readonly IMapper _mapper;
        public CategoriaService(IMapper mapper, ICategoriaRepository categoriaRepository)
        {
            _repository = categoriaRepository;
            _mapper = mapper;
        }
        public async Task Add(CategoriaDTO obj)
        {
            throw new NotImplementedException();
        }

        public async Task<CategoriaDTO> GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CategoriaDTO>> list()
        {
            try
            {
                var categoria = await _repository.ListarTodasCategorias();
                return _mapper.Map<List<CategoriaDTO>>(categoria);
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
