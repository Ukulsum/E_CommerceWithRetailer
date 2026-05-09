using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Accounts
{
    public class Group : BaseClass
    {
        public int Id { get; set; }
        public string Nature { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int? ParentGroupId { get; set; }
        public Group ParentGroup { get; set; }
        public int Level { get; set; }
    }
}
