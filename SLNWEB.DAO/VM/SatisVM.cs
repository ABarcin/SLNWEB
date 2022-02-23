using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNWEB.DAO.VM
{
    public class SatisVM
    {
        public List<ProductVM> Products { get; set; }
        public List<EmployeeVM> Employees { get; set; }
        public List<CategoryVM> Categories { get; set; }
        public List<ShipperVM> Shippers { get; set; }

    }
}
