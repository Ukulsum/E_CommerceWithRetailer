using Core.Entities.UserSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.UserSettings
{
    public interface ICustomerRepository : IRepository<CustomerInfo>
    {
    }
}
