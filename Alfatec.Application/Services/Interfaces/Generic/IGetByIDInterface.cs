namespace Alfatec.Application.Services.Interfaces.Generic
{
    public interface IGetByIDInterface<TEntity>
    {
        Task<TEntity> GetByID(int id);

    }
}
