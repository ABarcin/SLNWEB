using SLNWEB.Core;
using SLNWEB.DAL.Mapping;
using SLNWEB.DAO.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNWEB.DAL.Repository
{
    public class OrderDAL : EntityRepository<Order, NorthwindEntities>, IOrderDAL
    {
        public int AddOrder(OrderVM orderVM)
        {
            int value = this.Add(new OrderMapping().OrderVMToOrder(orderVM));
            return value;

        }
    }
}
