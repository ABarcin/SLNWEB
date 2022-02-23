using SLNWEB.Core;
using SLNWEB.DAL.Mapping;
using SLNWEB.DAO.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNWEB.DAL.Repository
{
    public class CustomerDAL : EntityRepository<Customer, NorthwindEntities>, ICustomerDAL
    {
        public CustomerVM GetCustomer(object id)
        {
            return new CustomerMapping().CustomerToCustomerVM(GetAll(x => x.CustomerID == id.ToString()).SingleOrDefault());
        }

        public List<CustomerVM> GetCustomerList()
        {
            return new CustomerMapping().ListCustomerToListCustomerVM(GetAll().ToList());
        }
    }
}
