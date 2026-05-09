using Core.Entities.Accounts;
using Core.Entities.CRM;
using Core.Entities.Files;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.UserSettings
{
    public class CustomerInfo : BaseClass
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public Ledger Ledger { get; set; }
        public int LedgerId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        //New Field//
        public string Status { get; set; } //Lead, Customer, Refused, Blacklist, Cancelled by Customer, Cancelled by Us
        public string ContactPerson { get; set; }
        public string MainAddressLine2 { get; set; }
        public string MainCity { get; set; }
        public string MainState { get; set; }
        public string MainPostCode { get; set; }
        public string MainCountry { get; set; }
        public string SecAddressLine1 { get; set; }
        public string SecAddressLine2 { get; set; }
        public string SecCity { get; set; }
        public string SecState { get; set; }
        public string SecPostCode { get; set; }
        public string SecCountry { get; set; }
        public string HomeTelephone { get; set; }
        public string WorkTelephone { get; set; }
        public string MobileTelephone { get; set; }
        public string Email { get; set; }
        public string Remarks { get; set; }
        public CRM_BusinessAreas CRM_BusinessAreas { get; set; }
        public int? CRM_BusinessAreasId { get; set; }
        public string MarketingBy { get; set; }
        public long? CRM_MarketerId { get; set; }
        public CRM_Marketer CRM_Marketer { get; set; }
        public long? CRM_MarketingRefId { get; set; }
        public CRM_Marketer CRM_MarketingRef { get; set; }
        public decimal? ClientPossibilities { get; set; }

        //*****//
        public string ContactNo { get; set; }
        public string NID { get; set; }
        public decimal? OpenningBalance { get; set; }
        public CompanyInfo CompanyInfo { get; set; }
        public int CompanyInfoId { get; set; }
        public Branch Branches { get; set; }
        public int BranchId { get; set; }
    }
}
