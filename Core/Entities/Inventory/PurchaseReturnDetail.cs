using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Inventory
{
    public class PurchaseReturnDetail
    {
        public int Id { get; set; }
        public int PurchaseReturnId { get; set; }
        public PurchaseReturn PurchaseReturn { get; set; }
        public long ItemId { get; set; }
        public Item Item { get; set; }
        public string ProductType { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal? SalePrice { get; set; }
        public decimal TotalPrice { get; set; }
        public bool IsDelete { get; set; }
        public decimal Tax { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal TotalAmount { get; set; }
        [NotMapped]
        public string SerialNo { get; set; }
    }
}
