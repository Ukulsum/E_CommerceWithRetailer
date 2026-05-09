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
    public class NewPurchaseReturn : BaseClass
    {
        public NewPurchaseReturn()
        {
            NewPurchaseReturnDetails = new List<NewPurchaseReturnDetails>();
        }

        public long Id { get; set; }
        public string ReturnInvoiceNo { get; set; }
        public DateTime ReturnDate { get; set; }
        public string PurchaseInvoiceNo { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string ReturnType { get; set; }
        public Supplier Supplier { get; set; }
        public long? SupplierId { get; set; }
        public Ledger Ledger { get; set; }
        public int? LedgerId { get; set; }
        public decimal? ReturnAmount { get; set; }
        public string Note { get; set; }
        public CompanyInfo CompanyInfo { get; set; }
        public int CompanyInfoId { get; set; }
        public Branch Branch { get; set; }
        public int? BranchId { get; set; }
        public Courier Couriers { get; set; }
        public long? CouriersId { get; set; }
        public string ArticleNo { get; set; }
        public ICollection<NewPurchaseReturnDetails> NewPurchaseReturnDetails { get; set; }
    }
}
