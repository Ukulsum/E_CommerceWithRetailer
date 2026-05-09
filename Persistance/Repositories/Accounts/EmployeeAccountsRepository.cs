using Core.Entities.Accounts;
using Core.Interfaces;
using Core.Interfaces.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.Accounts
{
    public class EmployeeAccountsRepository : IRepository<EmployeeAccounts>, IEmployeeAccountsRepository
    {
    }
}
