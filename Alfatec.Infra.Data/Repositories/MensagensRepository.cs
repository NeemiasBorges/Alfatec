using Alfatec.Domain.Entities;
using Alfatec.Infra.Data.Context;
using Alfatec.Infra.Data.Repositories.Interface;

namespace Alfatec.Infra.Data.Repositories
{
    public class MensagensRepository : IMensagemRepository
    {
        ApplicationDbContext _context;
        public MensagensRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task adicionarMensagem(Mensagem mensagem)
        {
            try
            {
                await _context.Mensagem.AddAsync(mensagem);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public async Task atualizarMensagem(Mensagem mensagem)
        {
            throw new NotImplementedException();
        }

        public async Task deletarMensagem(int id)
        {
            throw new NotImplementedException();
        }

        public Mensagem encontrarMensagemPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Mensagem> listarTodasAsMensagens()
        {
            throw new NotImplementedException();
        }
    }
}
