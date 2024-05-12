namespace Alfatec.Domain.Interfaces.GenericInterfaces
{
    public interface RemoveEntitie<IEntitie>
    {
        Task RemoveEntitieByID(int id);
    }
}
