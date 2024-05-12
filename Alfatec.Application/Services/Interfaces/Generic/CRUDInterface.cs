namespace Alfatec.Application.Services.Interfaces.Generic
{
    public interface CRUDInterface<TEntity> : IAddInterface<TEntity>, IRemoveInterface<TEntity>, IGetByIDInterface<TEntity>, IListInterface<TEntity>
    {
    }
}
