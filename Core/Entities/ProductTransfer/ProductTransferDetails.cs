using Core.Entities.Inventory;
using Core.Entities.ProductSetup;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ProductTransfer
{
    public class ProductTransferDetails
    {
        public long Id { get; set; }
        public ProductTransferMaster ProductTransfer { get; set; }
        public long ProductTransferId { get; set; }
        public Item Item { get; set; }
        public long ItemId { get; set; }
        public Unit Unit { get; set; }
        public int UnitId { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string ProductSlNo { get; set; }
        public bool IsReceived { get; set; }
        public bool IsDelete { get; set; }
        [NotMapped]
        public decimal? Stock { get; set; }
    }
}
