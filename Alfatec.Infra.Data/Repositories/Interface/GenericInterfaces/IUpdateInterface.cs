namespace Alfatec.Infra.Data.Repositories.Interface.GenericInterfaces
{
    public interface IUpdateInterface<TEntity>
    {
        Task Update(TEntity entity);
    }
}
