using Core.Entities.Inventory;
using Core.Entities.ProductSetup;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Production
{
    public class ProductionConfigDetails
    {
        public long Id { get; set; }
        //public ProductionConfigMaster ProductionConfigMst { get; set; }
        public long ProductionConfigMstId { get; set; }
        public Item Item { get; set; }
        public long ItemId { get; set; }
        public Unit Unit { get; set; }
        public int UnitId { get; set; }
        public decimal CostPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public bool IsDelete { get; set; }
        [NotMapped]
        public decimal StockQty { get; set; }
    }
}
