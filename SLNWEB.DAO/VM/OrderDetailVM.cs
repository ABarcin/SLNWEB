using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNWEB.DAO.VM
{
    public class OrderDetailVM
    {
        [Required]
        public int OrderID { get; set; }

        [Required]
        public int ProductID { get; set; }
        [Required]
        public decimal? UnitPrice { get; set; }
        [Required]
        public short? Quantity { get; set; }
        [Required]
        public float Discount { get; set; }


    }
}
