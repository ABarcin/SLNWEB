using SLNWEB.DAL.Repository;
using SLNWEB.DAO.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SLNWEB.UI.Controllers
{
    public class RaporController : Controller
    {
        // GET: Rapor

        CustomerDAL customerDal = new CustomerDAL();
        OrderDAL OrderDAL = new OrderDAL();
        ReportDAL reportDAL = new ReportDAL();
        public ActionResult Index()
        {
            var gelen = new ReportDAL().GetReportByCustomerID("ALFKI");
            ViewBag.Year = OrderDAL.GetYears();
            RaporVM raporVM = new RaporVM()
            {
                Customers = CustomerGetir(customerDal.GetCustomerList()),

            };

            return View(raporVM);
        }
        [HttpPost]
        public IEnumerable<CustomerOrderReportVM> RaporGetir(string customerID,int year)
        {
            //RaporVM raporVM = new RaporVM();
            //raporVM.Customer = new CustomerVM()
            //{
            //    CustomerID = customerID
            //};

            //List<CustomerOrderReportVM> raporVMs = reportDAL.GetReportByYearAndCustomerID(raporVM).Report.ToList();
            List<CustomerOrderReportVM> raporVMs = reportDAL.GetReportByCustomerID(customerID);

            return raporVMs;
        }

        private List<SelectListItem> CustomerGetir(List<CustomerVM> customerVMs)
        {
            return (from c in customerVMs
                    select new SelectListItem()
                    {
                        Text = c.CompanyName.ToUpper(),
                        Value = c.CustomerID.ToString()
                    }).ToList();
        }
    }
}