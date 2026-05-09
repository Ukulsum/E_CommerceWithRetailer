using Core.Entities.Accounts;
using Core.Entities.Files;
using Core.Entities.UserSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Inventory
{
    public class PurchaseReturn : BaseClass
    {
        public PurchaseReturn()
        {
            PurchaseReturnDetails = new List<PurchaseReturnDetail>();
        }
        public int Id { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime ReturnDate { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public int? SupplierLedgerId { get; set; }
        public int? PurchaseId { get; set; }
        public Purchase Purchase { get; set; }
        public int? LedgerId { get; set; }
        public Ledger Ledger { get; set; }

        public int CompanyInfoId { get; set; }
        public CompanyInfo CompanyInfo { get; set; }
        public decimal TotalBill { get; set; }
        public decimal? DeductAmount { get; set; }
        public decimal? Payable { get; set; }
        public decimal? PayAmount { get; set; }
        public decimal? DueAmount { get; set; }
        public decimal? PreviousBalance { get; set; }
        public string Note { get; set; }
        public Branch Branches { get; set; }
        public int BranchId { get; set; }

        public ICollection<PurchaseReturnDetail> PurchaseReturnDetails { get; set; }
    }
}
