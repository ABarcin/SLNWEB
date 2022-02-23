using SLNWEB.Core;
using SLNWEB.DAO.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNWEB.DAL.Mapping
{
    public class OrderMapping
    {
        public Order OrderVMToOrder(OrderVM vm)
        {
            return new Order()
            {
                OrderID = vm.OrderID,
                CustomerID = vm.CustomerID,
                ShipVia = vm.ShipVia,
                ShipName = vm.ShipName,
                ShipAddress = vm.ShipAddress,
                ShipCity = vm.ShipCity,
                ShipRegion = vm.ShipRegion,
                ShipPostalCode = vm.ShipPostalCode,
                ShipCountry = vm.ShipCountry,
                Freight = vm.Freight,
                EmployeeID = vm.EmployeeID,
                OrderDate = vm.OrderDate,
                RequiredDate = vm.RequiredDate,
                ShippedDate = vm.ShippedDate
            };
        }
        public OrderVM OrderToOrderVM(Order order)
        {
            return new OrderVM()
            {
                OrderID = order.OrderID,
                CustomerID = order.CustomerID,
                ShipVia = order.ShipVia,
                ShipName = order.ShipName,
                ShipAddress = order.ShipAddress,
                ShipCity = order.ShipCity,
                ShipRegion = order.ShipRegion,
                ShipPostalCode = order.ShipPostalCode,
                ShipCountry = order.ShipCountry,
                Freight = order.Freight,
                EmployeeID = order.EmployeeID,
                OrderDate = order.OrderDate,
                RequiredDate = order.RequiredDate,
                ShippedDate = order.ShippedDate
            };
        }
        public List<OrderVM> ListOrderToListOrderVM(List<Order> orders)
        {
            List<OrderVM> orderVMs = new List<OrderVM>();
            foreach (Order item in orders)
            {
                orderVMs.Add(OrderToOrderVM(item));
            }
            return orderVMs;
        }
        public List<Order> ListOrderVMToListOrder(List<OrderVM> vms)
        {
            List<Order> orders = new List<Order>();
            foreach (OrderVM item in vms)
            {
                orders.Add(OrderVMToOrder(item));
            }
            return orders;
        }
    }
}
