using Core.Entities.Accounts;
using Core.Interfaces.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.Accounts
{
    public class GroupRepository : Repository<Group>, IGroupRepository
    {
    }
}
