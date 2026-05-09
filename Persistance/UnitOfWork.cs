using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        public void Dispose()
        {
            //_context.Dispose();
        }

        public int Complete()
        {
            return 0;
            //return _context.SaveChanges();
        }
    }
}
