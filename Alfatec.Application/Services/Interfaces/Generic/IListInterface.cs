namespace Alfatec.Application.Services.Interfaces.Generic
{
    public interface IListInterface<TEntity>
    {
        Task<List<TEntity>> list();

    }
}
