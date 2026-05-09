using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Inventory
{
    public class RequisitionDetails
    {
        public long Id { get; set; }
        public Requisition Requisition { get; set; }
        public long RequisitionId { get; set; }
        public string Purpose { get; set; }
        public decimal Qty { get; set; }
        public decimal Amount { get; set; }
    }
}
