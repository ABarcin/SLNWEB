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
        public ActionResult Index(RaporVM raporVM = null)
        {
            //ViewBag.Year = OrderDAL.GetYears();
            if (raporVM.Report == null)
            {
                raporVM = new RaporVM()
                {
                    Customers = CustomerGetir(customerDal.GetCustomerList()),
                    Report = new List<CustomerOrderReportVM>()
                };
            }


            return View(raporVM);
        }

        //[HttpPost]
        //public ActionResult Index(RaporVM raporVM)
        //{
        //    RaporVM raporVMs = new RaporVM()
        //    {
        //        Customers = CustomerGetir(customerDal.GetCustomerList()),
        //        Report = reportDAL.GetReportByCustomerID(raporVM.Customer.CustomerID)
        //    };
        //    return View(raporVM);
        //}

        [HttpPost]
        public ActionResult CustomerSatisRapor(RaporVM rapor)
        {

            RaporVM raporVM = new RaporVM()
            {
                Customers = CustomerGetir(customerDal.GetCustomerList()),
                Report = reportDAL.GetReportByCustomerID(rapor.Customer.CustomerID)
            };

            return View("Index", raporVM);
        }

        /// <summary>
        /// script XMLHttpRequest için yazmıştık patladı bıraktık
        /// </summary>
        /// <param name="customerVMs"></param>
        /// <returns></returns>
        //[HttpPost]
        //public IEnumerable<CustomerOrderReportVM> RaporGetir(string customerID,int year)
        //{
        //    IEnumerable<CustomerOrderReportVM> raporVMs = reportDAL.GetReportByCustomerID(customerID);

        //   return raporVMs;
        //}

        private List<SelectListItem> CustomerGetir(List<CustomerVM> customerVMs)
        {
            return (from c in customerVMs
                    select new SelectListItem()
                    {
                        Text = c.CompanyName.ToUpper(),
                        Value = c.CustomerID.ToString()
                    }).ToList();
        }


        public ActionResult CustomerRapor(List<CustomerTopFiveReportVM> cusRaporVM = null)
        {
            ViewBag.Year ="";
            if (cusRaporVM == null)
            {
                cusRaporVM = new List<CustomerTopFiveReportVM>();
            }


            return View(cusRaporVM);
        }

        [HttpPost]
        public ActionResult CustomerRaporPost(string year)
        {
            List<CustomerTopFiveReportVM> cusRapor= reportDAL.GetTopFiveCustomerByYear(int.Parse(year));

            return View("CustomerRapor", cusRapor);
        }


    }
}