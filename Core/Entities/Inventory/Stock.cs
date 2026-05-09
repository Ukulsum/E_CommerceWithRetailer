using Core.Entities.Files;
using Core.Entities.ProductSetup;
using Core.Entities.UserSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Inventory
{
    public class Stock : BaseClass
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public string ItemType { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal? SalesPrice { get; set; }
        public string ReferenceTable { get; set; }
        public int ReferenceId { get; set; }
        public string StockType { get; set; }
        public DateTime StockDate { get; set; }
        public int CompanyInfoId { get; set; }
        public CompanyInfo CompanyInfo { get; set; }
        public Branch Branches { get; set; }
        public int BranchId { get; set; }
        public string SerialNo { get; set; }
        public Inv_Color Color { get; set; }
        public int? ColorId { get; set; }
        public Inv_Size Size { get; set; }
        public int? SizeId { get; set; }
        public string ArticleNo { get; set; }
        public string PriceCode { get; set; }
    }
}
