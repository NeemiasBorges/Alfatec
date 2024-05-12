namespace Alfatec.Infra.Data.Repositories.Interface.GenericInterfaces
{
    public interface IAddInterface<TEntity>
    {
        Task Add(TEntity entity);
    }
}
