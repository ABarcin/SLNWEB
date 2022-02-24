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
        public List<OrderVM> GetLastTenOrders()
        {
            return new OrderMapping().ListOrderToListOrderVM(this.GetAll().OrderByDescending(x=>x.OrderID).Take(10).ToList());
        }

        public List<int> GetYears()
        {
            return this.GetAll().Select(x => x.OrderDate.Value.Year).Distinct().ToList();
        }
    }
}
