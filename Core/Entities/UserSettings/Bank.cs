using Core.Entities.Accounts;
using Core.Entities.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.UserSettings
{
    public class Bank : BaseClass
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string AccountNo { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
        public decimal? OpenningBalance { get; set; }
        public int CompanyId { get; set; }
        public CompanyInfo Company { get; set; }
        public int LedgerId { get; set; }
        public Ledger Ledger { get; set; }
        public string RoutingNo { get; set; }
        public Branch Branches { get; set; }
        public int BranchId { get; set; }
    }
}
