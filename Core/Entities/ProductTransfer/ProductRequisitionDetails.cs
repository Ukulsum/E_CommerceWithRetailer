using Core.Entities.Inventory;
using Core.Entities.ProductSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ProductTransfer
{
    public class ProductRequisitionDetails
    {
        public long Id { get; set; }
        public ProductRequisitionMaster ProductReqMaster { get; set; }
        public long ProductReqMasterId { get; set; }
        public Item Item { get; set; }
        public long ItemId { get; set; }
        public Unit Unit { get; set; }
        public int UnitId { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public bool IsDelete { get; set; }
    }
}
