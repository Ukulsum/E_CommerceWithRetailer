using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Procedure_Model
{
    public class PurchaseReturnItemList
    {
        public long SupplierId { get; set; }
        public decimal Quantity { get; set; }
        public string ItemName { get; set; }
        public long ItemId { get; set; }
        public string UnitName { get; set; }
        public int UnitId { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SalesPrice { get; set; }
    }
}
