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
        public ActionResult Index()
        {
            return View(new CustomerDAL().GetCustomerList());
        }

        public ActionResult Add()
        {
            return View(new CustomerVM());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(CustomerVM customerVM)
        {
            if (ModelState.IsValid)
            {
                new CustomerDAL().AddCustomer(customerVM);
                return RedirectToAction("Add");
            }

            return View(customerVM);
        }

        //[HttpPost]
        //public ActionResult Delete(CustomerVM customerVM)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        //deye bagla elemanı ucur
        //        return RedirectToAction("Index", "Customer");
        //    }

        //    return View(customerVM);
        //}

        //[HttpGet]
        //public ActionResult Update(CustomerVM customerVM)
        //{
        //    if (customerVM == null)
        //    {
        //        return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
        //    }
        //    else
        //    {
        //        var customer = //dbden ara

        //        if (customer == null)
        //        {
        //            return HttpNotFound();
        //        }
        //        return View(customer);
        //    }
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult UpdatePost(CustomerVM customerVM)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        //daatbasee baglan elemanı guncelle
        //    }

        //    return View(customerVM);
        //}
    }
}