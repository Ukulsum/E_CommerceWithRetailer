using Core.Entities.Inventory;
using Core.Entities.ProductSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Production
{
    public class ProductFinishGoodDetails
    {
        public long Id { get; set; }
        public ProductFinishGoodMaster ProductFinishGood { get; set; }
        public long ProductFinishGoodId { get; set; }
        public Item Item { get; set; }
        public long ItemId { get; set; }
        public Unit Unit { get; set; }
        public int UnitId { get; set; }
        public decimal? SalesPrice { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Tax { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public bool IsDelete { get; set; }
        public string SerialNo { get; set; }
    }
}
