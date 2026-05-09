using Core.Entities.ProductSetup;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Inventory
{
    public class ExchangeSalesDetail
    {
        public int Id { get; set; }

        // Link to ExchangeSales
        public int ExchangeSalesId { get; set; }
        public ExchangeSales ExchangeSale { get; set; }

        // Item info
        [ForeignKey("Item")]
        public long ItemId { get; set; }
        public Item Item { get; set; }

        // Quantity & pricing
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public int UnitId { get; set; }
        public Unit Unit { get; set; }
        public decimal? Discount { get; set; }
        public decimal? SalesPrice { get; set; }
        public string SerialNo { get; set; }
        public string Model { get; set; }
        //public decimal VatAmount { get; set; }
        //public decimal TotalAmount { get; set; }
        // Variants
        public int? ColorId { get; set; }
        public Inv_Color Color { get; set; }
        public int? SizeId { get; set; }
        public Inv_Size Size { get; set; }
        public string ArticleNo { get; set; }

        // Soft delete
        public bool IsDelete { get; set; }
        //public object Unit { get; set; }
    }
}
