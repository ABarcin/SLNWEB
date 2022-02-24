using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNWEB.DAO.VM
{
    public class CustomerOrderReportVM
    {
        public string CustomerName { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
