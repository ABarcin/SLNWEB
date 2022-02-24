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
    public class CustomerDemographicDAL : EntityRepository<CustomerDemographic, NorthwindEntities>, ICustomerDemographicDAL
    {
        public int AddCustomerDemographic(CustomerDemographicVM customerDemographic)
        {
            return Add(new CustomerDemographicMapping().CustomerDemographicVMToCustomerDemographic(customerDemographic));
        }

        public int Delete(CustomerDemographicVM customerDemographicVM)
        {
            return Delete(new CustomerDemographicMapping().CustomerDemographicVMToCustomerDemographic(customerDemographicVM));
        }

        public List<CustomerDemographicVM> GetCustomerDemographicList()
        {
            return new CustomerDemographicMapping().ListCustomerDemographicToListCustomerDemographicVM(GetAll().ToList());
        }
    }
}
