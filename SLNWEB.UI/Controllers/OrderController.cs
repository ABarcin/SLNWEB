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
        CategoryDAL categoryDal = new CategoryDAL();
        ProductDAL productDal = new ProductDAL();
        //ICategoryDAL _catagoryDal;

        [HttpGet]
        public ActionResult SatisYap()
        {
            
            ViewBag.Catagories = new SelectList(categoryDal.GetAllCategories());
            SatisVM satisVM = new SatisVM() { 
      
            
            };
            
            return View(satisVM);
        }

        [HttpPost]
        public ActionResult SatisYap(SatisYapVM satis)
        {
            //order tabla ekle
            return View();
        }

    }
}