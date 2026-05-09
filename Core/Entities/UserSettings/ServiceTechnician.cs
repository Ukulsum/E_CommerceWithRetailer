using Core.Entities.Accounts;
using Core.Entities.Files;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.UserSettings
{
    public class ServiceTechnician : BaseClass
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public Ledger Ledger { get; set; }
        public int LedgerId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string NID { get; set; }
        public decimal? OpeningBalance { get; set; }
        public CompanyInfo CompanyInfo { get; set; }
        public int CompanyInfoId { get; set; }
        public Branch Branches { get; set; }
        public int BranchId { get; set; }
    }
}
