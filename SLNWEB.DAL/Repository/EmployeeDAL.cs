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
    public class EmployeeDAL : EntityRepository<Employee, NorthwindEntities>, IEmployeeDAL
    {
        public List<EmployeeVM> GettAllEmployee()
        {
            return new EmployeeMapping().ListEmployeeToListEmployeeVM(this.GetAll()).ToList();
        }
    }
}
