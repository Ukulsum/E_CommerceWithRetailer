using Core.Entities.Files;
using Core.Interfaces.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.Files
{
    public class CompanyRepository : Repository<CompanyInfo>, ICompanyRepository
    {
    }
}
