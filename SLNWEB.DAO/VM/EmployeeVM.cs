using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNWEB.DAO.VM
{
    public class EmployeeVM
    {
        public int EmployeeID { get; set; }

        [Required]
        [StringLength(20)]
        public string LastName { get; set; }

        [Required]
        [StringLength(10)]
        public string FirstName { get; set; }
        public override string ToString()
        {
            return (FirstName + " " + LastName).ToUpper();
        }
    }
}
