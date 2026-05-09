using Core.Entities.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Accounts
{
    public class EmployeeAccounts : BaseClass
    {
        public long Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public string TransactionType { get; set; }
        public decimal Amount { get; set; }
        public string Note { get; set; }
        public int PaymentLedger { get; set; }
        public string SalaryMonth { get; set; }
        public int CompanyInfoId { get; set; }
        public CompanyInfo CompanyInfo { get; set; }
    }
}
