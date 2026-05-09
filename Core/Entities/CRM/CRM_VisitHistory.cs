using Core.Entities.Files;
using Core.Entities.UserSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.CRM
{
    public class CRM_VisitHistory : BaseClass
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public long CustomerInfoId { get; set; }
        public CustomerInfo CustomerInfo { get; set; }
        [Required]
        public DateTime VisitDate { get; set; }
        public DateTime? ReVisitDate { get; set; }
        public string Tag { get; set; }
        public string Remarks { get; set; }
        public CompanyInfo CompanyInfo { get; set; }
        public int CompanyInfoId { get; set; }
        public Branch Branches { get; set; }
        public int BranchId { get; set; }

        public string AssignBy { get; set; }
        public string Assignee { get; set; }
        public string Status { get; set; } //Mark as complete
        public string IsShowCalender { get; set; }
        public string IsReminder { get; set; }
    }
}
