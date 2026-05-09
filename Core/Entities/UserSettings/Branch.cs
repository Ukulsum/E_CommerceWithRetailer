using Core.Entities.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.UserSettings
{
    public class Branch : BaseClass
    {
        public int Id { get; set; }
        public CompanyInfo Company { get; set; }
        public int CompanyId { get; set; }
        public string BranchName { get; set; }
        public string Address { get; set; }
    }
}
