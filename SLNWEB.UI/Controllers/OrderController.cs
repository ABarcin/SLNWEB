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


        [HttpGet]
        public ActionResult SatisYap()
        {
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