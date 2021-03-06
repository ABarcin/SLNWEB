using SLNWEB.Core;
using SLNWEB.DAO.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNWEB.DAL.Repository
{
    interface ICustomerDAL : IEntityRepository<Customer>
    {
        List<CustomerVM> GetCustomerList();

        CustomerVM GetCustomer(object id);

        int AddCustomer(CustomerVM customer);

        int DeleteCustomer(CustomerVM customer);

        int UpdateCustomer(CustomerVM customer);
    }
}
