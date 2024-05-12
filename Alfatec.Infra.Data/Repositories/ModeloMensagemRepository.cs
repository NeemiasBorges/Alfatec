using Alfatec.Domain.Entities;
using Alfatec.Infra.Data.Context;
using Alfatec.Infra.Data.Repositories.Interface;

namespace Alfatec.Infra.Data.Repositories
{
    public class ModeloMensagemRepository : IModeloMensagemRepository
    {
        ApplicationDbContext _context;
        public ModeloMensagemRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AtualizarAutorizacao(ModeloMensagem modeloMensagem)
        {
            throw new NotImplementedException();
        }

        public async Task CriarModelo(ModeloMensagem modeloMensagem)
        {
            throw new NotImplementedException();
        }

        public async Task<ModeloMensagem> GetModeloById(int ID)
        {
            return await _context.ModeloMensagem.FindAsync(ID);
        }
    }
}
