using Core.Entities.UserSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ServiceInfo
{
    public class ServiceDtl
    {
        public int Id { get; set; }
        public int ServiceMstId { get; set; }
        public ServiceMst ServiceMst { get; set; }
        public string ServiceName { get; set; }
        public decimal? ServiceCharge { get; set; }
        public string Remarks { get; set; }
        public ServiceTechnician ServiceTechnician { get; set; }
        public long ServiceTechnicianId { get; set; }
    }
}
