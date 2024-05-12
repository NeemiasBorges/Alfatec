namespace Alfatec.Domain.Interfaces.GenericInterfaces
{
    public interface GetEntitie<IEntity>
    {
        Task<List<IEntity>> Get();
        Task<IEntity> GetByID(int ID);
    }
}
