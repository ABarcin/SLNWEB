using SLNWEB.DAL.Repository;
using SLNWEB.DAO.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SLNWEB.UI.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }

        IOrderDAL _orderDAL;
        ICategoryDAL _categoryDAL;
        [HttpGet]
        public ActionResult SatisYap()
        {

            //ViewBag.Catagories = new SelectList(_categoryDAL.GetAllCategories());
            SatisVM satisVM = new SatisVM();
            
            return View(satisVM);
        }

        [HttpPost]
        public ActionResult SatisYap(SatisYapVM satis)
        {
            return View();
        }

    }
}