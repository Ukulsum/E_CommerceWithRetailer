using Core.Entities.Files;
using Core.Entities.UserSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Inventory
{
    public class ProductLoanMaster : BaseClass
    {
        public ProductLoanMaster()
        {
            ProductLoanDetails = new List<ProductLoanDetails>();
        }
        public long Id { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime LoanDate { get; set; }
        public Supplier Supplier { get; set; }
        public long SupplierId { get; set; }
        public string ProductLoanType { get; set; }
        public string ProductLoanStatus { get; set; }
        public decimal TotalBill { get; set; }
        public string Note { get; set; }
        public CompanyInfo CompanyInfo { get; set; }
        public int CompanyInfoId { get; set; }
        public Branch Branches { get; set; }
        public int BranchId { get; set; }
        public ICollection<ProductLoanDetails> ProductLoanDetails { get; set; }
    }
}
