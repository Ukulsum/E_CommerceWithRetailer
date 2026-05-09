using Core.Entities.ProductSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Inventory
{
    public class SalesReturnDetail
    {
        public int Id { get; set; }
        public int SalesReturnId { get; set; }
        public SalesReturn SalesReturn { get; set; }
        public long ItemId { get; set; }
        public Item Item { get; set; }
        public int UnitId { get; set; }
        //public Unit Unit { get; set; }
        public string ProductType { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal? CostPrice { get; set; }
        public bool IsDelete { get; set; }
        public decimal Vat { get; set; }
        public decimal VatAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public Inv_Color Color { get; set; }
        public int? ColorId { get; set; }
        public Inv_Size Size { get; set; }
        public int? SizeId { get; set; }
        public string PriceCode { get; set; }
        public string ArticleNo { get; set; }
    }
}
