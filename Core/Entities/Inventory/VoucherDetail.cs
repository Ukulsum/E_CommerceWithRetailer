using Core.Entities.Accounts;
using Core.Entities.UserSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Inventory
{
    public class VoucherDetail
    {
        public long Id { get; set; }
        public long VoucherEntryId { get; set; }
        public VoucherEntry VoucherEntry { get; set; }
        public int LedgerId { get; set; }
        public Ledger Ledger { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Debit { get; set; }
        public string ChequeNo { get; set; }
        public string LedgerType { get; set; }
        public Branch Branches { get; set; }
        public int BranchId { get; set; }
        public int? IsApproved { get; set; }
        public int? GroupId { get; set; }
    }
}
