using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SLNWEB.DAO.VM
{
    public class RaporVM
    {
        public List<SelectListItem> Customers { get; set; }
        public DateTime Year { get; set; }
        public CustomerVM Customer { get; set; }
        public decimal Price { get; set; }
    }
}
