using Core.Entities.Files;
using Core.Entities.UserSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Inventory
{
    public class StockAdjustmentMst : BaseClass
    {
        public StockAdjustmentMst()
        {
            StockAdjustmentDtls = new List<StockAdjustmentDtls>();
        }
        public int Id { get; set; }
        public int CompanyInfoId { get; set; }
        public CompanyInfo CompanyInfo { get; set; }
        public DateTime RequestDate { get; set; }
        public string Reason { get; set; }
        public string EntryUser { get; set; }
        public string Type { get; set; }
        public int Status { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public Branch Branches { get; set; }
        public int BranchId { get; set; }
        public ICollection<StockAdjustmentDtls> StockAdjustmentDtls { get; set; }
    }
}
