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
    public class PurchaseRequisition : BaseClass
    {
        public PurchaseRequisition()
        {
            PurchaseRequisitionDetails = new List<PurchaseRequisitionDetails>();
        }

        public long Id { get; set; }
        [Required]
        public string ReqInvoiceNo { get; set; }
        public Supplier Supplier { get; set; }
        public long SupplierId { get; set; }
        public DateTime RequisitionDate { get; set; }
        public string ChalanNo { get; set; }
        public decimal? PreviousBalance { get; set; }
        public decimal TotalBill { get; set; }
        public decimal? Discount { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public decimal? Tax { get; set; }
        public decimal? TaxPercentage { get; set; }
        public decimal? LaborCharge { get; set; }
        public decimal? TransportBill { get; set; }
        public decimal? ExtraPrice { get; set; }
        public decimal? Payable { get; set; }
        public decimal? PayAmount { get; set; }
        public decimal? Balance { get; set; }
        public string Note { get; set; }
        public CompanyInfo CompanyInfo { get; set; }
        public int CompanyInfoId { get; set; }
        public Branch Branches { get; set; }
        public int BranchId { get; set; }
        public ICollection<PurchaseRequisitionDetails> PurchaseRequisitionDetails { get; set; }
    }
}
