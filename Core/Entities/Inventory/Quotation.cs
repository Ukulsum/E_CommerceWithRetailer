using Core.Entities.Files;
using Core.Entities.ProductSetup;
using Core.Entities.UserSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Inventory
{
    public class Quotation : BaseClass
    {
        public Quotation()
        {
            QuotationDetails = new List<QuotationDetail>();
        }
        public int Id { get; set; }
        [Required]
        public string InvoiceNo { get; set; }

        public long? CustomerInfoId { get; set; }
        public CustomerInfo CustomerInfo { get; set; }
        public string CustomerName { get; set; }
        public string CustomerType { get; set; }


        public string ContactNo { get; set; }
        public string Address { get; set; }
        public DateTime QuotationDate { get; set; }
        public int CompanyInfoId { get; set; }
        public CompanyInfo CompanyInfo { get; set; }

        public decimal TotalBill { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Vat { get; set; }
        public decimal? LaborCharge { get; set; }
        public decimal? TransportBill { get; set; }
        public decimal? ExtraBill { get; set; }
        public decimal? Payable { get; set; }
        public string Note { get; set; }

        // Akash
        public string Subject { get; set; }
        public string validity { get; set; }
        public string TermsOfPayment { get; set; }
        public string Warranty { get; set; }

        // Generator
        public Brand Brand { get; set; }
        public int? BrandId { get; set; }
        public string ModelName { get; set; }
        public string CountryOfOrigin { get; set; }
        public string Shipment { get; set; }
        public string Rating { get; set; }
        public string Phase { get; set; }
        public string Frequency { get; set; }
        public string FuelTankCapacity { get; set; }
        public string PowerFactor { get; set; }
        public string FuelConsumptionLPH { get; set; }

        //Engine
        public string Manufacturer { get; set; }
        public string EngineCountryOfOrigin { get; set; }
        public string EngineModel { get; set; }
        public string EngineType { get; set; }
        public string RatedRPM { get; set; }
        public string CylinderArrangement { get; set; }
        public string CompressonRatio { get; set; }
        public string Governor { get; set; }

        // Alternator
        public string AlternatorManufacturer { get; set; }
        public string AlternatorCountryOfOrigin { get; set; }
        public string AlternatorModel { get; set; }
        public string Type { get; set; }
        public string VoltageRegulation { get; set; }

        // Controller
        public string ControllerManufacturer { get; set; }
        public string ControllerCountryOfOrigin { get; set; }
        public string ControllerModel { get; set; }

        //End

        public string Designation { get; set; } // New Add Column
        public string ServiceWarranty { get; set; } // New Add Column

        public string LdsModel { get; set; } // New Add Column
        public string SignatureName { get; set; } // New Column Add
        public string SignatureDesignation { get; set; } // New Column Add
        public string SignatureMobileNo { get; set; } // New Column Add

        public string VatType { get; set; } // New Column Add
        public string Currency { get; set; } // New Column Add

        public Branch Branches { get; set; }
        public int BranchId { get; set; }
        public string DiscountType { get; set; }
        public decimal? AIT { get; set; }
        public string AITType { get; set; }
        public string TermsCondition { get; set; }

        public ICollection<QuotationDetail> QuotationDetails { get; set; }
    }
}
