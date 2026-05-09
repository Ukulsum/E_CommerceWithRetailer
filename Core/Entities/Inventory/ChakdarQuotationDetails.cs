using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Inventory
{
    public class ChakdarQuotationDetails
    {
        public int Id { get; set; }
        //public ChakdarQuotations Quotation { get; set; }
        public int QuotationId { get; set; }
        public long? ItemId { get; set; }
        //public Item Item { get; set; }
        public string ItemDetails { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        public int? UnitId { get; set; }
        //public Unit Unit { get; set; }
        public int? UnitEqualPics { get; set; }
        public int? UnitQuantity { get; set; }
        public bool IsDelete { get; set; }
        public string ServiceName { get; set; }
        public decimal? ServiceCharge { get; set; }
        public string Remarks { get; set; }

        [NotMapped]
        public decimal? Stock { get; set; }
    }
}
