using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SLNWEB.DAO.VM
{
    public class SatisVM
    {
        public List<SelectListItem> Products { get; set; }
        public List<SelectListItem> Employees { get; set; }
        public List<SelectListItem> Categories { get; set; }
        public List<SelectListItem> Shippers { get; set; }
        public OrderVM Order { get; set; }
        public OrderDetailVM OrderDetail { get; set; }
        public CategoryVM Catagory { get; set; }

    }
}
