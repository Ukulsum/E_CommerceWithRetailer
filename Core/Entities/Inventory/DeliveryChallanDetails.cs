using Core.Entities.ProductSetup;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Inventory
{
    public class DeliveryChallanDetails
    {
        public int Id { get; set; }
        public int? SalesId { get; set; }
        public Sales Sales { get; set; }
        //[Required]
        //[ForeignKey("Item")]
        public Item Item { get; set; }

        [ForeignKey("Item")]
        public long ItemId { get; set; }
        public string Model { get; set; } // New Column Add
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public int UnitId { get; set; }
        public Unit Unit { get; set; }
        public int? UnitEqualPics { get; set; }
        public int? UnitQuantity { get; set; }
        public bool IsDelete { get; set; }
        public decimal? CostPrice { get; set; }
        public DeliveryChallan DeliveryChallan { get; set; }
        public int DeliveryChallanId { get; set; }
        public long? QuotationId { get; set; } // New Column Add   
        public decimal Vat { get; set; }
        public decimal VatAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public string SerialNo { get; set; }
    }
}
