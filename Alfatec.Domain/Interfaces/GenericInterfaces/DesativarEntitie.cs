namespace Alfatec.Domain.Interfaces.GenericInterfaces
{
    public interface DesativarEntitie<IEntitie>
    {
        Task DesativarByID(int id);
    }
}
