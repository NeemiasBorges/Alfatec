using Alfatec.Domain.Entities;

namespace Alfatec.Infra.Data.Repositories.Interface.GenericInterfaces
{
    public interface IComumActions<TEntity>
    {
        Task Add(Mensagem mensagem);
        Mensagem FindByID(int id);
        Task<List<TEntity>> listAll();
        Task Att(Mensagem mensagem);
        Task Dele(int id);
    }
}
