using Core.Entities.Files;
using Core.Entities.ProductSetup;
using Core.Entities.UserSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Assert
{
    public class Office_Assert
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public int UnitId { get; set; }
        public Unit Unit { get; set; }
        public decimal price { get; set; }
        public string decription { get; set; }
        public CompanyInfo CompanyInfo { get; set; }
        public int CompanyInfoId { get; set; }
        public Branch Branches { get; set; }
        public int BranchId { get; set; }
    }
}
