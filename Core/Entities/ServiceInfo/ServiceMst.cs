using Core.Entities.Files;
using Core.Entities.UserSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ServiceInfo
{
    public class ServiceMst : BaseClass
    {
        public ServiceMst()
        {
            ServiceDtls = new List<ServiceDtl>();
        }
        public int Id { get; set; }
        public int CompanyInfoId { get; set; }
        public CompanyInfo CompanyInfo { get; set; }

        public string CustomerType { get; set; }
        public CustomerInfo CustomerInfo { get; set; }
        public int? CustomerInfoId { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public DateTime ServiceDate { get; set; }
        public string InvoiceNo { get; set; }

        public decimal? PreviousBill { get; set; }
        public decimal? ServiceTotalPrice { get; set; } //Service Price
        public decimal? ServicePayable { get; set; }
        public decimal? ServicePayAmount { get; set; }
        public decimal? TotalBill { get; set; } //Service+Item Price
        public decimal? Balance { get; set; }  //Due Tk

        public int? ReceiptLedger { get; set; }
        public int? LedgerId { get; set; }

        public decimal? DiscountPercentage { get; set; }
        public decimal? Discount { get; set; }
        public decimal? VatPercentage { get; set; }
        public decimal? Vat { get; set; }

        public Branch Branches { get; set; }
        public int BranchId { get; set; }
        public ICollection<ServiceDtl> ServiceDtls { get; set; }
    }
}
