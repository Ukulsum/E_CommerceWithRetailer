using Core.Entities.ProductSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Inventory
{
    public class NewPurchaseReturnDetails
    {
        public long Id { get; set; }
        public NewPurchaseReturn NewPurchaseReturn { get; set; }
        public long NewPurchaseReturnId { get; set; }
        public Item Item { get; set; }
        public long ItemId { get; set; }
        public Unit Unit { get; set; }
        public int UnitId { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal StockQty { get; set; }
        public decimal ReturnQty { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Tax { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public string SerialNo { get; set; }
        public bool IsDelete { get; set; }
        public Inv_Color Color { get; set; }
        public int? ColorId { get; set; }
        public Inv_Size Size { get; set; }
        public int? SizeId { get; set; }
    }
}
