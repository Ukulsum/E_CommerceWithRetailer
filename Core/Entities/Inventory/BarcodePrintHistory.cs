using Core.Entities.Files;
using Core.Entities.UserSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Inventory
{
    public class BarcodePrintHistory : BaseClass
    {
        public long Id { get; set; }
        public Purchase Purchase { get; set; }
        public int? PurchaseId { get; set; }
        public string InvoiceNo { get; set; }
        public string ArticleNo { get; set; }
        public long PrintCount { get; set; }
        public CompanyInfo CompanyInfo { get; set; }
        public int CompanyInfoId { get; set; }
        public Branch Branches { get; set; }
        public int BranchId { get; set; }
    }
}
