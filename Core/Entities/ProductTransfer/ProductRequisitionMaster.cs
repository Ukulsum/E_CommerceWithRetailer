using Core.Entities.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ProductTransfer
{
    public class ProductRequisitionMaster : BaseClass
    {
        public ProductRequisitionMaster()
        {
            ProductReqDetails = new List<ProductRequisitionDetails>();
        }
        public long Id { get; set; }
        public string RequesterName { get; set; }
        public DateTime RequisitionDate { get; set; }
        public int FromBranch { get; set; }
        public int ToBranch { get; set; }
        public decimal TotalQuantity { get; set; }
        public decimal TotalPrice { get; set; }
        public CompanyInfo CompanyInfo { get; set; }
        public int CompanyInfoId { get; set; }
        public ICollection<ProductRequisitionDetails> ProductReqDetails { get; set; }
    }
}
