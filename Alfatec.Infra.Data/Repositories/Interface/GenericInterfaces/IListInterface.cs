namespace Alfatec.Infra.Data.Repositories.Interface.GenericInterfaces
{
    public interface IListInterface<TEntity>
    {
        Task Add(TEntity entity);
    }
}
