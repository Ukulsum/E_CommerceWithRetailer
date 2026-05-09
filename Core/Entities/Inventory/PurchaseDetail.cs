using Core.Entities.ProductSetup;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Inventory
{
    public class PurchaseDetail
    {
        public int Id { get; set; }
        public int PurchaseId { get; set; }
        public Purchase Purchase { get; set; }
        public long ItemId { get; set; }
        public Item Item { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal? SalesPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public int UnitId { get; set; }
        public Unit Unit { get; set; }
        public int? UnitEqualPics { get; set; }
        public int? UnitQuantity { get; set; }
        public bool IsDelete { get; set; }
        public string InvoiceDocument { get; set; }
        public string SerialNo { get; set; }
        public decimal Tax { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public Inv_Color Color { get; set; }
        public int? ColorId { get; set; }
        public Inv_Size Size { get; set; }
        public int? SizeId { get; set; }
        public string PriceCode { get; set; }
        [NotMapped]
        public string ToSerialNo { get; set; }
    }
}
