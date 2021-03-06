using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNWEB.DAO.VM
{
    public class CategoryVM
    {
        public int CategoryID { get; set; }

        [Required]
        [StringLength(15)]
        public string CategoryName { get; set; }

        public override string ToString()
        {
            return CategoryName.ToUpper();
        }
    }
}
