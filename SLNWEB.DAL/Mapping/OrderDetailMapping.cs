using SLNWEB.Core;
using SLNWEB.DAO.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNWEB.DAL.Mapping
{
    public class OrderDetailMapping
    {
        public Order_Detail OrderDetailVMToOrder_Detail(OrderDetailVM vm)
        {
            return new Order_Detail()
            {
                OrderID=vm.OrderID,
                ProductID=vm.ProductID,
                Quantity=vm.Quantity,
                Discount=vm.Discount,
                UnitPrice=vm.UnitPrice
                
            };
        }
        public OrderDetailVM Order_DetailToOrderDetailVM(Order_Detail order_Detail)
        {
            return new OrderDetailVM()
            {
                OrderID = order_Detail.OrderID,
                ProductID = order_Detail.ProductID,
                Quantity = order_Detail.Quantity,
                Discount = order_Detail.Discount,
                UnitPrice = order_Detail.UnitPrice

            };
        }
        public List<Order_Detail> ListOrderDetailVMToOrder_Detail(List<OrderDetailVM> vms)
        {
            List<Order_Detail> order_Details = new List<Order_Detail>();
            foreach (OrderDetailVM item in vms)
            {
                OrderDetailVMToOrder_Detail(item);
            }
            return order_Details;
        }
        public List<OrderDetailVM> ListOrder_DetailToOrderDetail(List<Order_Detail> order_Details)
        {
            List<OrderDetailVM> vms = new List<OrderDetailVM>();
            foreach (Order_Detail item in order_Details)
            {
                Order_DetailToOrderDetailVM(item);
            }
            return vms;
        }
    }
}
