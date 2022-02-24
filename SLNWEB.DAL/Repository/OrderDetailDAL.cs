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
    public class OrderDetailDAL : EntityRepository<Order_Detail, NorthwindEntities>, IOrderDetailDAL
    {
        public int AddOrderDetail(OrderDetailVM orderDetailVM)
        {
            return this.Add(new OrderDetailMapping().OrderDetailVMToOrder_Detail(orderDetailVM));
        }

        public List<OrderDetailVM> GetAllOrderDetails()
        {
            return new OrderDetailMapping().ListOrder_DetailToOrderDetail( this.GetAll());
        }
    }
}
