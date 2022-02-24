using SLNWEB.DAL.Repository;
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
        public ActionResult Index()
        {
            return View();
        }

     
    }
}