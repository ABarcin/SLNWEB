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

        //[HttpPost]
        //public ActionResult _UpdateCustomer(int CustomerID = 0)
        //{
        //    CustomerVM customerVM = new CustomerVM();
        //    return PartialView("_UpdateCustomer", customerVM);
        //}

        public ActionResult Update(object id)
        {
            return View(new CustomerDAL().GetCustomer(id));
        }

        [HttpPost]
        public ActionResult Update(CustomerVM customerVM)
        {
            if (customerVM != null)
            {
                new CustomerDAL().UpdateCustomer(customerVM);
            }

            return RedirectToAction("Listeleme", "Customer");
        }
        public ActionResult Add()
        {
            return View(new CustomerVM());
        }

        [HttpPost]
        public ActionResult Add(CustomerVM customerVM)
        {
            if (ModelState.IsValid)
            {
                new CustomerDAL().AddCustomer(customerVM);
                return RedirectToAction("Listeleme", "Customer");
            }

            return View(customerVM);
        }

    }
}