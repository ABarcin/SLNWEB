using SLNWEB.DAO.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNWEB.DAL.Repository
{
    public interface IReportDAL
    {
        RaporVM GetReportByYearAndCustomerID(RaporVM raporVM);
    }
}
