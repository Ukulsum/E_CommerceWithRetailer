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
    public class ChakdarQuotations : BaseClass
    {
        public ChakdarQuotations()
        {
            chakdarQuotationDetails = new List<ChakdarQuotationDetails>();
        }
        public int Id { get; set; }
        [Required]
        public string InvoiceNo { get; set; }

        public long? CustomerInfoId { get; set; }
        public CustomerInfo CustomerInfo { get; set; }
        public string CustomerName { get; set; }
        public string CustomerType { get; set; }


        public DateTime QuotationDate { get; set; }
        public int CompanyInfoId { get; set; }
        public CompanyInfo CompanyInfo { get; set; }

        public string Designation { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string Subject { get; set; }


        public string SignatureName { get; set; }
        public string SignatureDesignation { get; set; }
        public string SignatureMobileNo { get; set; }

        public string VatType { get; set; }
        public string Currency { get; set; }

        public decimal TotalBill { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Vat { get; set; }
        public decimal? LaborCharge { get; set; }
        public decimal? TransportBill { get; set; }
        public decimal? ExtraBill { get; set; }
        public decimal? Payable { get; set; }
        public string Note { get; set; }
        public Branch Branches { get; set; }
        public int BranchId { get; set; }
        public ICollection<ChakdarQuotationDetails> chakdarQuotationDetails { get; set; }
    }
}
