using Core.Entities.Files;
using Core.Entities.UserSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Accounts
{
    public class Ledger : BaseClass
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }
        public int Level { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public bool IsPrimaryAccount { get; set; }
        public decimal? InitialBalance { get; set; }
        public int CompanyInfoId { get; set; }
        public CompanyInfo CompanyInfo { get; set; }
        public Branch Branches { get; set; }
        public int? BranchId { get; set; }
    }
}
