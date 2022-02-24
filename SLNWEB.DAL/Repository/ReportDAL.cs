using SLNWEB.Core;
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
        public List<CustomerOrderReportVM> GetReportByCustomerID(string customerID)
        {
            List<CustomerOrderReportVM> query = (from c in new CustomerDAL().GetAll().ToList()
                                                 join o in new OrderDAL().GetAll().ToList() on c.CustomerID equals o.CustomerID
                                                 join od in new OrderDetailDAL().GetAll() on o.OrderID equals od.OrderID
                                                 where c.CustomerID == customerID
                                                 group new { c, od } by new { c, od, o } into gr
                                                 select new CustomerOrderReportVM
                                                 {
                                                     OrderDate = gr.Key.o.OrderDate.Value.ToShortDateString(),
                                                     CustomerName = gr.Key.c.CompanyName,
                                                     Count=gr.Count(),
                                                     Price = gr.Sum(x => x.od.Quantity * x.od.UnitPrice * (decimal)(1 - x.od.Discount)),
                                                 }).ToList();
            return query;

        }
    }
}
