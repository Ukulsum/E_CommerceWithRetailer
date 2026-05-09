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
    public class ExchangeSales : BaseClass
    {
        public ExchangeSales()
        {
            ExchangeSaleDetails = new List<ExchangeSalesDetail>();
            SaleDetails = new List<SalesDetail>();
        }

        public int Id { get; set; }

        public int? SalesId { get; set; } // Link to original sale
        //public Sales Sales { get; set; }

        public int CompanyInfoId { get; set; }
        public CompanyInfo CompanyInfo { get; set; }

        public decimal TotalBill { get; set; }
        public decimal? TotalDiscount { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Payable { get; set; }
        public decimal? PayAmount { get; set; }

        public Branch Branches { get; set; }
        public int BranchId { get; set; }

        [Required]
        public string ExchangeInvoiceNo { get; set; } // Unique invoice for exchange sale

        public DateTime ExchangeDate { get; set; }
        public decimal TotalExchangeAmount { get; set; }

        public string Note { get; set; }

        // Collection of exchange sale details
        public ICollection<ExchangeSalesDetail> ExchangeSaleDetails { get; set; }
        public ICollection<SalesDetail> SaleDetails { get; set; }
    }
}
