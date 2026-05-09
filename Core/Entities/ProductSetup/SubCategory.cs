using Core.Entities.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ProductSetup
{
    public class SubCategory : BaseClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }

        public CompanyInfo CompanyInfo { get; set; }
        public int CompanyInfoId { get; set; }
    }
}
