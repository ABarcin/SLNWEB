using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNWEB.DAO.VM
{
    public class CustomerTopFiveReportVM
    {
        public string CustomerID { get; set; }
        public string CustomerFullName { get; set; }
        public string TotalPrice { get; set; }
        public string Count { get; set; }
        public string Year { get; set; }
    }
}
