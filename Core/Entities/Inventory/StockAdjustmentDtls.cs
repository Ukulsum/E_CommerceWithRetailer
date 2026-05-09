using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Inventory
{
    public class StockAdjustmentDtls
    {
        public int Id { get; set; }
        public int StockAdjustmentMstId { get; set; }
        public StockAdjustmentMst StockAdjustmentMst { get; set; }
        public long ItemId { get; set; }
        public Item Item { get; set; }
        public decimal Quantity { get; set; }
    }
}
