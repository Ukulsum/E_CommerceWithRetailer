using Core.Entities.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Inventory
{
    public class ItemTypes : BaseClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CompanyInfo CompanyInfo { get; set; }
        public int CompanyInfoId { get; set; }
    }
}
