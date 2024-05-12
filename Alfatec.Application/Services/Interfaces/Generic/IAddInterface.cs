namespace Alfatec.Application.Services.Interfaces.Generic
{
    public interface IAddInterface<IEntity>
    {
        Task Add(IEntity obj);
    }
}
