namespace Alfatec.Domain.Interfaces.GenericInterfaces
{
    public interface UpdateEntitie<IEntitie>
    {
        Task<IEntitie> GetById(IEntitie entitie);
    }
}
