namespace Alfatec.Domain.Interfaces.GenericInterfaces
{
    public interface GetEntitie<IEntity>
    {
        Task<ICollection<IEntity>> Get();
        Task<IEntity> GetByID(int ID);
    }
}
