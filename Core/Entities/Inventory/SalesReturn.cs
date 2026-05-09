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
    public class SalesReturn : BaseClass
    {
        public SalesReturn()
        {
            SalesReturnDetails = new List<SalesReturnDetail>();
        }
        public int Id { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime ReturnDate { get; set; }
        public decimal TotalBill { get; set; }
        public decimal? DeductAmount { get; set; }
        public decimal Payable { get; set; }
        public decimal? PayAmount { get; set; }
        public decimal? DueAmount { get; set; }
        public decimal? PreviousBalance { get; set; }
        public string Note { get; set; }
        public int CompanyInfoId { get; set; }
        public CompanyInfo CompanyInfo { get; set; }

        public int? SalesId { get; set; }
        public Sales Sales { get; set; }
        public string CustomerType { get; set; }
        public int? CustomerInfoId { get; set; }
        public CustomerInfo CustomerInfo { get; set; }
        public string CustomerName { get; set; }
        public int? CustomerLedgerId { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public int? LedgerId { get; set; }
        public Ledger Ledger { get; set; }
        public Branch Branches { get; set; }
        public int BranchId { get; set; }
        public Courier Couriers { get; set; }
        public long? CouriersId { get; set; }
        public string ArticleNo { get; set; }
        public ICollection<SalesReturnDetail> SalesReturnDetails { get; set; }
    }
}
