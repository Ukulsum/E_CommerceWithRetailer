using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Files
{
    public class SetModulePermission : BaseClass
    {
        public long Id { get; set; }
        public ModuleInfo ModuleInfo { get; set; }
        public int ModuleInfoId { get; set; }
        public int CompanyInfoId { get; set; }
        public CompanyInfo CompanyInfo { get; set; }
        public int IsEnableModule { get; set; }
    }
}
