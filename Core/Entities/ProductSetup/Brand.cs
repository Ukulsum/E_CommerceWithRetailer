using Core.Entities.Files;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ProductSetup
{
    public class Brand : BaseClass
    {
        //    public int Id { get; set; }

        //    [StringLength(255)]
        //    public string Name { get; set; }

        //    [StringLength(255)]
        //    [ValidateNever]
        //    public string LogoPath { get; set; }

        //    [NotMapped]
        //    //[ValidateNever]
        //    public IFormFile Logo { get; set; }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public CompanyInfo CompanyInfo { get; set; }
        public int CompanyInfoId { get; set; }
    }   
}
