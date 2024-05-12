namespace Alfatec.Domain.Interfaces.GenericInterfaces
{
    public interface AddEntitie<IEntitie>
    {
        Task Add(IEntitie entitie);
    }
}
