using Core.Entities.Files;
using Core.Entities.Inventory;
using Core.Entities.ProductSetup;
using Core.Entities.UserSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Production
{
    public class ProductionConfigMaster : BaseClass
    {
        public ProductionConfigMaster()
        {
            ProductionConfigDetails = new List<ProductionConfigDetails>();
        }
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public string ItemCode { get; set; }
        public Item Item { get; set; }
        public long ItemId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
        public int? SubCategoryId { get; set; }
        public string ItemName { get; set; }
        public decimal CostPrice { get; set; }
        public decimal? SalesPrice { get; set; }
        public CompanyInfo CompanyInfo { get; set; }
        public int CompanyInfoId { get; set; }
        public Branch Branch { get; set; }
        public int? BranchId { get; set; }
        public ICollection<ProductionConfigDetails> ProductionConfigDetails { get; set; }
    }
}
