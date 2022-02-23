using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNWEB.DAO.VM
{
    public class SatisYapVM
    {
        public ProductVM Product { get; set; }
        public EmployeeVM Employee { get; set; }
        public CategoryVM Category { get; set; }
        public ShipperVM Shipper { get; set; }
    }
}
