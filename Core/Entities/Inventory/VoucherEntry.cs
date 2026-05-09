using Core.Entities.Files;
using Core.Entities.UserSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Inventory
{
    public class VoucherEntry : BaseClass
    {
        public long Id { get; set; }
        public string VoucherNo { get; set; }
        public string VoucherName { get; set; }
        public DateTime TransactionDate { get; set; }
        public string ReferenceTable { get; set; }
        public int ReferenceId { get; set; }
        public string ReferenceInvoice { get; set; }
        public int CompanyInfoId { get; set; }
        public CompanyInfo CompanyInfo { get; set; }
        public string AdjustmentTye { get; set; }
        public string Remark { get; set; }
        public string ChequeNo { get; set; }
        public string Document { get; set; }
        public Branch Branches { get; set; }
        public int BranchId { get; set; }
        public DateTime? ChequeClearDate { get; set; }
        public string ChequeBankName { get; set; }
        public int? Year { get; set; }
        public int? MonthNo { get; set; }
        public string Month { get; set; }
        public int? IsApproved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string TransactionType { get; set; }
        public Courier Couriers { get; set; }
        public long? CouriersId { get; set; }
        public ICollection<VoucherDetail> VoucherDetails { get; set; }
    }
}
