using Core.Entities.Files;
using Core.Entities.UserSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.CRM
{
    public class CRM_Marketer : BaseClass
    {
        public long Id { get; set; }
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public decimal? SalesCommissionPercentage { get; set; }
        public string MainAddress { get; set; }
        public string MainCity { get; set; }
        public string MainState { get; set; }
        public string MainPostCode { get; set; }
        public string MainCountry { get; set; }
        public string SecondAddress { get; set; }
        public string SecCity { get; set; }
        public string SecState { get; set; }
        public string SecPostCode { get; set; }
        public string SecCountry { get; set; }
        public string HomeTelephone { get; set; }
        public string WorkTelephone { get; set; }
        public string MobileTelephone { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public int IsActive { get; set; }
        public string MarketerType { get; set; }
        public CompanyInfo CompanyInfo { get; set; }
        public int CompanyInfoId { get; set; }
        public Branch Branches { get; set; }
        public int BranchId { get; set; }
    }
}
