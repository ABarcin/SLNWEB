using SLNWEB.Core;
using SLNWEB.DAO.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNWEB.DAL.Mapping
{
    public class CustomerMapping
    {
        public Customer CustomerVMToCustomer(CustomerVM vm)
        {
            return new Customer()
            {
                CustomerID = vm.CustomerID,
                CompanyName = vm.CompanyName,
                ContactName = vm.ContactName,
                ContactTitle = vm.ContactTitle,
                Address = vm.Address,
                City = vm.City,
                Region = vm.Region,
                PostalCode = vm.PostalCode,
                Country = vm.Country,
                Phone = vm.Phone,
                Fax = vm.Fax
            };
        }

        public CustomerVM CustomerToCustomerVM(Customer entity)
        {
            return new CustomerVM()
            {
                CustomerID = entity.CustomerID,
                CompanyName = entity.CompanyName,
                ContactName = entity.ContactName,
                ContactTitle = entity.ContactTitle,
                Address = entity.Address,
                City = entity.City,
                Region = entity.Region,
                PostalCode = entity.PostalCode,
                Country = entity.Country,
                Phone = entity.Phone,
                Fax = entity.Fax
            };
        }

        public List<Customer> ListCustomerVMToListCustomer(List<CustomerVM> vms)
        {
            List<Customer> Customers = new List<Customer>();

            foreach (CustomerVM vm in vms)
            {
                Customers.Add(CustomerVMToCustomer(vm));
            }

            return Customers;
        }

        public List<CustomerVM> ListCustomerToListCustomerVM(List<Customer> entities)
        {
            List<CustomerVM> CustomerVMs = new List<CustomerVM>();

            foreach (Customer entity in entities)
            {
                CustomerVMs.Add(CustomerToCustomerVM(entity));
            }

            return CustomerVMs;
        }
    }
}
