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
                                                     Count = gr.Count().ToString(),
                                                     Price = gr.Sum(x => x.od.Quantity * x.od.UnitPrice * (decimal)(1 - x.od.Discount)).ToString(),
                                                 }).ToList();
            return query;

        }

        public List<CustomerTopFiveReportVM> GetTopFiveCustomerByYear(int year)
        {
            List<CustomerTopFiveReportVM> vms = (from c in new CustomerDAL().GetAll().ToList()
                                                 join o in new OrderDAL().GetAll().ToList() on c.CustomerID equals o.CustomerID
                                                 join od in new OrderDetailDAL().GetAll().ToList() on o.OrderID equals od.OrderID
                                                 where o.OrderDate.Value.Year == year
                                                 group new { o, od, c } by new { o.CustomerID, o.OrderDate.Value.Year } into g
                                                 select new CustomerTopFiveReportVM
                                                 {
                                                     CustomerID = g.Key.CustomerID,
                                                     CustomerFullName = g.Where(x => x.c.CustomerID == g.Key.CustomerID).FirstOrDefault().c.ContactName,
                                                     TotalPrice = g.Sum(x => x.od.Quantity * x.od.UnitPrice).ToString(),
                                                     Count = g.Select(x => x.o.OrderID).Distinct().Count().ToString(),
                                                     Year = g.Key.Year.ToString()
                                                 }).OrderByDescending(x=>x.TotalPrice).Take(5).ToList();
            return vms;
        }
    }
}
