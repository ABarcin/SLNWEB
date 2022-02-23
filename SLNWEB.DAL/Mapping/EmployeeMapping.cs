using SLNWEB.Core;
using SLNWEB.DAO.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNWEB.DAL.Mapping
{
    public class EmployeeMapping
    {
        public Employee EmployeeVMToEmployee(EmployeeVM vm)
        {
            return new Employee()
            {
                EmployeeID = vm.EmployeeID,
                FirstName = vm.FirstName,
                LastName = vm.LastName
            };
        }
        public EmployeeVM EmployeeToEmployeeVM(Employee employee)
        {
            return new EmployeeVM()
            {
                EmployeeID = employee.EmployeeID,
                FirstName = employee.FirstName,
                LastName = employee.LastName
            };
        }
        public List<EmployeeVM> ListEmployeeToListEmployeeVM(List<Employee> employees)
        {
            List<EmployeeVM> employeeVMs = new List<EmployeeVM>();
            foreach (Employee item in employees)
            {
                employeeVMs.Add(EmployeeToEmployeeVM(item));
            }
            return employeeVMs;
        }
        public List<Employee> ListEmployeeToVMListEmployee(List<EmployeeVM> vms)
        {
            List<Employee> employees = new List<Employee>();
            foreach (EmployeeVM item in vms)
            {
                employees.Add(EmployeeVMToEmployee(item));
            }
            return employees;
        }
    }
}
