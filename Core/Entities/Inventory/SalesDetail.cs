using Core.Entities.ProductSetup;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Inventory
{
    public class SalesDetail
    {
        public int Id { get; set; }
        public int SalesId { get; set; }
        public Sales Sales { get; set; }
        //[Required]
        //[ForeignKey("Item")]
        public Item Item { get; set; }
        [ForeignKey("Item")]
        public long ItemId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public int UnitId { get; set; }
        public Unit Unit { get; set; }
        public int? UnitEqualPics { get; set; }
        public int? UnitQuantity { get; set; }
        public bool IsDelete { get; set; } //
        public decimal? CostPrice { get; set; }
        public string Model { get; set; }
        public DeliveryChallan DeliveryChallan { get; set; }
        public int? DeliveryChallanId { get; set; }
        public string SerialNo { get; set; }
        public decimal Vat { get; set; }
        public decimal VatAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public Inv_Color Color { get; set; }
        public int? ColorId { get; set; }
        public Inv_Size Size { get; set; }
        public int? SizeId { get; set; }
        public string ArticleNo { get; set; }

        // Exchange Section
        //public int? ExchangeId { get; set; }
        //public ExchangeSales ExchangeSales { get; set; }
        public decimal? ChangeQty { get; set; }
        public decimal? Discount { get; set; }
    }
}
