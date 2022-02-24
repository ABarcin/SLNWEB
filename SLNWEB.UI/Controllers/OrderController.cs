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

        CategoryDAL categoryDal = new CategoryDAL();
        SatisDAL satisDal = new SatisDAL();
        //ICategoryDAL _catagoryDal;

        [HttpGet]
        public ActionResult SatisYap()
        {
            return View((new SatisVM()
            {
                Categories = GetCategories(categoryDal.GetAllCategories()),
                Employees = GetEmployees(new EmployeeDAL().GettAllEmployee()),
                Products = GetProducts(new ProductDAL().GetAllProduct()),
                Shippers = GetShippers(new ShipperDAL().GetAllShipper()),
                Order = new OrderVM(),
                Catagory = new CategoryVM(),
                OrderDetail = new OrderDetailVM()
            }));
        }

        private List<SelectListItem> GetShippers(List<ShipperVM> shipperVMs)
        {
            return (from s in shipperVMs
                    select new SelectListItem()
                    {
                        Text = s.CompanyName,
                        Value = s.ShipperID.ToString()
                    }).ToList();
        }

        private List<SelectListItem> GetProducts(List<ProductVM> productVMs)
        {
            return (from p in productVMs
                    select new SelectListItem()
                    {
                        Text = p.ProductName,
                        Value = p.ProductID.ToString()
                    }).ToList();
        }

        private List<SelectListItem> GetEmployees(List<EmployeeVM> employeeVMs)
        {
            return (from e in employeeVMs
                    select new SelectListItem()
                    {
                        Text = e.FirstName + " " + e.LastName,
                        Value = e.EmployeeID.ToString()
                    }).ToList();
        }

        private List<SelectListItem> GetCategories(List<CategoryVM> categoryVMs)
        {
            return (from c in categoryVMs
                    select new SelectListItem()
                    {
                        Text = c.CategoryName,
                        Value = c.CategoryID.ToString()
                    }).ToList();
        }

        [HttpPost]
        public ActionResult SatisYap(SatisVM satis)
        {
            if (ModelState.IsValid&&satis!=null)
            {
                int value = satisDal.AddSatis(satis);
                //order tabla ekle
                if (value > 0)
                {
                    return RedirectToAction("Index");
                }
            }
            
            return View();
        }

    }
}