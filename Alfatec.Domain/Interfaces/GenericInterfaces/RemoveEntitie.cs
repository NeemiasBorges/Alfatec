using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Alfatec.Domain.Interfaces.GenericInterfaces
{
    public interface RemoveEntitie<IEntitie>
    {
        Task RemoveEntitieByID(int id);
    }
}
