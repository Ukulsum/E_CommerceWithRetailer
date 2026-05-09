using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Files
{
    public class CompanyInfo : BaseClass
    {
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Website { get; set; }
        public string Director { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Slogans { get; set; }
        public string AreaCode { get; set; }
        public string TinNo { get; set; }
        public string TagLine { get; set; }
        public string LogoUrl { get; set; }
    }
}
