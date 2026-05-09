using Core.Entities.Files;
using Core.Entities.Inventory;
using Core.Entities.UserSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Production
{
    public class ProductFinishGoodMaster : BaseClass
    {
        public ProductFinishGoodMaster()
        {
            ProductFinishGoodDetails = new List<ProductFinishGoodDetails>();
        }

        public long Id { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime Date { get; set; }
        public Item Item { get; set; }
        public long ItemId { get; set; }
        public ProductionConfigMaster ProductionConfigMst { get; set; }
        public long ProductionConfigMstId { get; set; }
        public decimal ProductionCostPrice { get; set; }
        public decimal ProductTotalQuantiy { get; set; }
        public CompanyInfo CompanyInfo { get; set; }
        public int CompanyInfoId { get; set; }
        public Branch Branches { get; set; }
        public int BranchId { get; set; }
        public ICollection<ProductFinishGoodDetails> ProductFinishGoodDetails { get; set; }
    }
}
