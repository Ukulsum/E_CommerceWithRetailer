using Core.Entities.ProductSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Inventory
{
    public class PurchaseRequisitionDetails
    {
        public long Id { get; set; }
        public PurchaseRequisition PurchaseRequisition { get; set; }
        public long PurchaseRequisitionId { get; set; }
        public Item Item { get; set; }
        public long ItemId { get; set; }
        public Unit Unit { get; set; }
        public int UnitId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal Tax { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal? SalesPrice { get; set; }
        public bool IsDelete { get; set; }
        public string SerialNo { get; set; }
        public string ToSerialNo { get; set; }
    }
}
