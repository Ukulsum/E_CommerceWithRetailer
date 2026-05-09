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
    public class Sales : BaseClass
    {
        public Sales()
        {
            SalesDetails = new List<SalesDetail>();
        }
        public int Id { get; set; }
        [Required]
        public string InvoiceNo { get; set; }

        public int? NewInvoiceId { get; set; }
        public string CustomerType { get; set; }
        public int? CustomerInfoId { get; set; }
        public CustomerInfo CustomerInfo { get; set; }
        public string CustomerName { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string ChalanStatus { get; set; } //
        public int? LedgerId { get; set; }
        public Ledger Ledger { get; set; }
        public int? ReceiptLedger { get; set; } //
        public int CompanyInfoId { get; set; }
        public CompanyInfo CompanyInfo { get; set; }
        public DateTime SalesDate { get; set; }
        public DateTime? PossiblePaymentDate { get; set; }
        public decimal TotalBill { get; set; }
        public decimal? PreviousBill { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Vat { get; set; }
        public decimal? LaborCharge { get; set; }
        public decimal? TransportBill { get; set; }
        public decimal? ExtraBill { get; set; }
        public decimal? Payable { get; set; }
        public decimal? PayAmount { get; set; }
        public decimal? Balance { get; set; }
        public string Note { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public decimal? TaxPercentage { get; set; }
        public string ChequeNo { get; set; }
        public int? ServiceMstId { get; set; } //
        public string Warranty { get; set; }

        public DeliveryChallan DeliveryChallan { get; set; }
        public int? DeliveryChallanId { get; set; }

        public bool PrintApproved { get; set; } // New Column Add 
        public DateTime? PrintApprovedDate { get; set; } // New Column Add 
        public string PrintApprovedBy { get; set; } // New Column Add 
        public Branch Branches { get; set; }
        public int BranchId { get; set; }
        public string EmiStatus { get; set; }
        public string EmiPaymentStatus { get; set; }
        public string ChequeClearDate { get; set; }
        public string ChequeBankName { get; set; }
        public string ReferenceName { get; set; }
        public Courier Couriers { get; set; }
        public long? CouriersId { get; set; }
        public string ArticleNo { get; set; }
        public ICollection<SalesDetail> SalesDetails { get; set; }
    }
}
