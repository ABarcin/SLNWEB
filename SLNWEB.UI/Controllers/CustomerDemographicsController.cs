using SLNWEB.DAL.Repository;
using SLNWEB.DAO.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SLNWEB.UI.Controllers
{
    public class CustomerDemographicsController : Controller
    {
        // GET: CustomerDemographics
        public ActionResult Index()
        {
            return View(new CustomerDemographicDAL().GetCustomerDemographicList());
        }

        public ActionResult Add()
        {
            return View(new CustomerDemographicVM());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(CustomerDemographicVM customerDemographicVM)
        {
            if (ModelState.IsValid)
            {
                new CustomerDemographicDAL().AddCustomerDemographic(customerDemographicVM);
                return RedirectToAction("Add","CustomerDemographics");
            }
            return View(customerDemographicVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(CustomerDemographicVM customerDemographicVM)
        {
            if (ModelState.IsValid)
            {
                new CustomerDemographicDAL().AddCustomerDemographic(customerDemographicVM);
                return RedirectToAction("Delete","CustomerDemographics");
            }
            return View(customerDemographicVM);
        }
    }
}