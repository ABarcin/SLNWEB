using SLNWEB.DAL.Repository;
using SLNWEB.DAO.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SLNWEB.UI.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Listeleme()
        {
            return View(new CustomerDAL().GetCustomerList());
        }

        [HttpPost]
        public ActionResult _UpdateCustomer(int CustomerID = 0)
        {
            return PartialView("_UpdateCustomer");
        }

    }
}