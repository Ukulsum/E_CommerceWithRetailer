using Core.Entities.Files;
using Core.Entities.UserSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Inventory
{
    public class Requisition : BaseClass
    {
        public Requisition()
        {
            RequisitionDetails = new List<RequisitionDetails>();
        }
        public long Id { get; set; }
        public DateTime RequisitionDate { get; set; }
        public string RequesterName { get; set; }
        public string Designation { get; set; }
        public string RequisitionTypes { get; set; }
        public CompanyInfo CompanyInfo { get; set; }
        public int CompanyInfoId { get; set; }
        public decimal TotalAmount { get; set; }
        public string ProjectName { get; set; }
        public Branch Branches { get; set; }
        public int BranchId { get; set; }
        public ICollection<RequisitionDetails> RequisitionDetails { get; set; }
    }
}
