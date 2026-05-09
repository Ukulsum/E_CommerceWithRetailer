using Core.Entities.ProductTransfer;
using Core.Interfaces.ProductTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.ProductTransfer
{
    public class ProductRequisitionRepository : Repository<ProductRequisitionMaster>, IProductRequisitionRepository
    {
    }
}
