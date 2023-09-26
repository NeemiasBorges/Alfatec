using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfatec.Domain.Interfaces.GenericInterfaces
{
    public interface UpdateEntitie<IEntitie>
    {
        Task<IEntitie> GetById(IEntitie entitie);
    }
}
