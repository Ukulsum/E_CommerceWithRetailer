using Core.Entities.Accounts;
using Core.Entities.Files;
using Core.Entities.UserSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Inventory
{
    public class PurchaseOneTest
    {
        public PurchaseOneTest()
        {
            PurchaseDetails = new List<PurchaseDetail>();
        }
        public int Id { get; set; }
        [Required]
        public string InvoiceNo { get; set; }
        public long SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public int? LedgerId { get; set; }
        public Ledger Ledger { get; set; }
        public int CompanyInfoId { get; set; }
        public CompanyInfo CompanyInfo { get; set; }
        public string ChalanUrl { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal TotalBill { get; set; }
        public decimal? Discount { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public decimal? Tax { get; set; }
        public decimal? TaxPercentage { get; set; }
        public decimal? LaborCharge { get; set; }
        public decimal? TransportBill { get; set; }
        public decimal? Payable { get; set; }
        public decimal? PayAmount { get; set; }
        public decimal? Balance { get; set; }
        public string Note { get; set; }
        public string ReferenceTable { get; set; }
        public int? ReferenceId { get; set; }
        public int PaymentLedger { get; set; }
        public decimal? ExtraPrice { get; set; }
        public decimal? PreviousBalance { get; set; }
        public ICollection<PurchaseDetail> PurchaseDetails { get; set; }
    }
}
