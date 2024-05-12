using Alfatec.Domain.Entities;
using Alfatec.Infra.Data.Context;
using Alfatec.Infra.Data.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Alfatec.Infra.Data.Repositories
{
    public class EnderecoRepository : IEnderecoRepository
    {
        ApplicationDbContext _context;
        public EnderecoRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task addCondicoes(Condicoes condicoes)
        {
            await _context.Condicoes.AddAsync(condicoes);
            await _context.SaveChangesAsync();
        }

        public async Task AtualizarEndereco(Endereco enderecoAtualizado)
        {
            throw new NotImplementedException();
        }

        public async Task<Endereco> BuscarEnderecoPorId(int idEndereco)
        {
            throw new NotImplementedException();
        }

        public async Task CriarEndereco(Endereco novoEndereco)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Condicoes>> listaCondicoes()
        {
            var condicoes = await _context.Condicoes.ToListAsync();
            return condicoes;
        }

        public async Task<List<Endereco>> ListarTodosEnderecos()
        {
            throw new NotImplementedException();
        }

        public async Task RemoverEndereco(int idEndereco)
        {
            throw new NotImplementedException();
        }
    }
}
