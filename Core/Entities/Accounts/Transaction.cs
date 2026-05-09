using Core.Entities.Files;
using Core.Entities.UserSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Accounts
{
    public class Transaction : BaseClass
    {
        public int Id { get; set; }
        public string InvoiceNo { get; set; }
        public string TransactionVoucher { get; set; }
        public string Purpose { get; set; }
        public string LedgerPerson { get; set; }
        public int? LedgerId { get; set; }
        public Ledger Ledger { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Debit { get; set; }
        public bool IsCheque { get; set; }
        public string ChequeNo { get; set; }
        public DateTime TransactionDate { get; set; }
        public string ReferenceTable { get; set; }
        public int ReferenceId { get; set; }
        public string Remark { get; set; }
        public string LedgerType { get; set; }
        public string AdjustmentTye { get; set; }
        public int CompanyInfoId { get; set; }
        public CompanyInfo CompanyInfo { get; set; }
        public Branch Branches { get; set; }
        public int BranchId { get; set; }
    }
}
