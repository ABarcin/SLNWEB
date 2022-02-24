using SLNWEB.DAO.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNWEB.DAL.Repository
{
    public class ReportDAL : IReportDAL
    {
        public RaporVM GetReportByYearAndCustomerID(RaporVM raporVM)
        {
            raporVM.Report = new List<CustomerOrderReportVM>();
            raporVM.Report = (from c in new CustomerDAL().GetCustomerList()
                              join o in new OrderDAL().GetAllOrders() on c.CustomerID equals o.CustomerID
                              join od in new OrderDetailDAL().GetAllOrderDetails() on o.OrderID equals od.OrderID
                              where c.CustomerID == raporVM.Customer.CustomerID
                              group new { c, od } by new { c, od, o } into gr
                              select new CustomerOrderReportVM
                              {
                                  OrderDate = gr.Key.o.OrderDate.Value,
                                  CustomerName = gr.Key.c.CompanyName,
                                  Price = gr.Sum(x => x.od.Quantity * x.od.UnitPrice * (decimal)(1 - x.od.Discount)),
                                  Count = gr.Count()
                              }).ToList();
            return raporVM;
        }
    }
}
