using SLNWEB.Core;
using SLNWEB.DAO.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNWEB.DAL.Repository
{
    public interface IOrderDAL:IEntityRepository<Order>  
    {
        int AddOrder(OrderVM orderVM);
        List<int> GetYears();
    }
}
