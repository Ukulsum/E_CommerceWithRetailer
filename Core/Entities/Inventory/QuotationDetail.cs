using Core.Entities.ProductSetup;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Inventory
{
    public class QuotationDetail
    {
        public int Id { get; set; }
        public int QuotationId { get; set; }
        public Quotation Quotation { get; set; }
        public long? ItemId { get; set; }
        public Item Item { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        public int? UnitId { get; set; }
        public Unit Unit { get; set; }
        public int? UnitEqualPics { get; set; }
        public int? UnitQuantity { get; set; }
        public bool IsDelete { get; set; }
        public string ServiceName { get; set; }
        public decimal? ServiceCharge { get; set; }
        public string Remarks { get; set; }
        public decimal Vat { get; set; }
        public decimal VatAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public string SerialNo { get; set; }
        public string Description { get; set; }
        [NotMapped]
        public decimal? Stock { get; set; }
        public string Model { get; set; } // New Column Add 
        public decimal? CostPrice { get; set; }
    }
}
