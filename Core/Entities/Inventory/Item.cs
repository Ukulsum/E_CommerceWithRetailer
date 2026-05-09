using Core.Entities.Accounts;
using Core.Entities.Files;
using Core.Entities.ProductSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Inventory
{
    public class Item : BaseClass
    {
        public long Id { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public SubCategory SubCategory { get; set; }
        public int? SubCategoryId { get; set; }
        public Brand Brand { get; set; }
        public int? BrandId { get; set; }
        //public long SupplierId { get; set; }
        // public Supplier Supplier { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal? OpeningStock { get; set; }
        public int? ReorderLevel { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SalePrice { get; set; }
        public decimal DearlerPrice { get; set; }
        public decimal PreviousPrice { get; set; }
        public int UnitId { get; set; }
        //public Unit Unit { get; set; }
        public int? UnitEqualPices { get; set; }
        public decimal TransportCost { get; set; }
        public CompanyInfo CompanyInfo { get; set; }
        public int CompanyInfoId { get; set; }
        public int LedgerId { get; set; }
        public Ledger Ledger { get; set; }
        public string ItemPic { get; set; }
        public string ProductNo { get; set; }
        public decimal Vat { get; set; }
        public decimal Tax { get; set; }
        public ItemTypes ItemTypes { get; set; }
        public int? ItemTypesId { get; set; }
    }
}
