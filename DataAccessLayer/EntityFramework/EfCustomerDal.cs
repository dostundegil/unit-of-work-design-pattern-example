using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate;
using DataAccessLayer.Repositories;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCustomerDal:GenericRepository<Customer>,ICustomerDal
    {
        public EfCustomerDal(Context _context):base(_context)
        {
                
        }
    }
}
