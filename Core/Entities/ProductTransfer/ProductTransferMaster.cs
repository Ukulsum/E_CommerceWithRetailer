using Core.Entities.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ProductTransfer
{
    public class ProductTransferMaster : BaseClass
    {
        public ProductTransferMaster()
        {
            ProductTransferDetails = new List<ProductTransferDetails>();
        }
        public long Id { get; set; }
        public string TransferCode { get; set; }
        public DateTime TransferDate { get; set; }
        public string TransferBy { get; set; }
        public string ChallanNo { get; set; }
        public int FromBranch { get; set; }
        public int ToBranch { get; set; }
        public decimal TotalQuantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string ReceivedBy { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public CompanyInfo CompanyInfo { get; set; }
        public int CompanyInfoId { get; set; }
        public ICollection<ProductTransferDetails> ProductTransferDetails { get; set; }
    }
}
