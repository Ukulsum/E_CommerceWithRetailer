using Core.Entities.Accounts;
using Core.Entities.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.UserSettings
{
    public class Employee : BaseClass
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Ledger Ledger { get; set; }
        public int LedgerId { get; set; }
        public string Designation { get; set; }
        public decimal Salary { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }
        public CompanyInfo CompanyInfo { get; set; }
        public int CompanyInfoId { get; set; }
        public string NidNo { get; set; }
        public string NidFrontpic { get; set; }
        public string NidBackPic { get; set; }
        public string EmployeePic { get; set; }
        public string File { get; set; }
    }
}
