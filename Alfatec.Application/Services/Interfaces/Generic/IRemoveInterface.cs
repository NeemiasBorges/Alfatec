namespace Alfatec.Application.Services.Interfaces.Generic
{
    public interface IRemoveInterface<TEntity>
    {
        Task Remove(int id);
    }
}
