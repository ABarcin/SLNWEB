using SLNWEB.Core;
using SLNWEB.DAO.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNWEB.DAL.Mapping
{
    public class CustomerDemographicMapping
    {

        public CustomerDemographic CustomerDemographicVMToCustomerDemographic(CustomerDemographicVM vm)
        {
            return new CustomerDemographic()
            {
                CustomerTypeID = vm.CustomerTypeID,
                CustomerDesc = vm.CustomerDesc
            };
        }

        public CustomerDemographicVM CustomerDemographicToCustomerDemographicVM(CustomerDemographic entity)
        {
            return new CustomerDemographicVM()
            {
                CustomerTypeID = entity.CustomerTypeID,
                CustomerDesc = entity.CustomerDesc
            };
        }

        public List<CustomerDemographic> ListCustomerDemographicVMToListCustomerDemographic(List<CustomerDemographicVM> vms)
        {
            List<CustomerDemographic> customerDemographics = new List<CustomerDemographic>();

            foreach (CustomerDemographicVM vm in vms)
            {
                customerDemographics.Add(CustomerDemographicVMToCustomerDemographic(vm));
            }
            return customerDemographics;

        }

        public List<CustomerDemographicVM> ListCustomerDemographicToListCustomerDemographicVM(List<CustomerDemographic> entities)
        {
            List<CustomerDemographicVM> customerDemographicVMs = new List<CustomerDemographicVM>();

            foreach (CustomerDemographic entity in entities)
            {
                customerDemographicVMs.Add(CustomerDemographicToCustomerDemographicVM(entity));
            }

            return customerDemographicVMs;
        }




    }
}
