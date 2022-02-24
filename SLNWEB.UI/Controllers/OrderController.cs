﻿using SLNWEB.DAL.Repository;
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

        //IOrderDAL _orderDAL;
        CategoryDAL categoryDal = new CategoryDAL();
        ProductDAL productDal = new ProductDAL();
        EmployeeDAL employeeDal = new EmployeeDAL();
        ShipperDAL shipperDal = new ShipperDAL();

        [HttpGet]
        public ActionResult SatisYap()
        {
            
            ViewBag.Catagories = new SelectList(categoryDal.GetAllCategories());
            SatisVM satisVM = new SatisVM() {
                Products = ProductGetir(productDal.GetAllProductVMByCategoryID(1)),
                Employees=EmployeeGetir(employeeDal.GettAllEmployee()),
                Shippers=ShipperGetir(shipperDal.GetAllShipper()),
                Order=new OrderVM()
            };

            
            return View(satisVM);
        }

        private List<SelectListItem> ShipperGetir(List<ShipperVM> shipperVMs)
        {
            return (from s in shipperVMs
                    select new SelectListItem()
                    {
                        Text = s.CompanyName.ToUpper(),
                        Value = s.ShipperID.ToString()
                    }
            ).ToList();
        }

        private List<SelectListItem> EmployeeGetir(List<EmployeeVM> employeeVMs)
        {
            return (from e in employeeVMs
                    select new SelectListItem()
                    {
                        Text = (e.FirstName+" "+e.LastName).ToUpper(),
                        Value = e.EmployeeID.ToString()
                    }
                    ).ToList();
        }

        private List<SelectListItem> ProductGetir(List<ProductVM> productVMs)
        {
            return (from p in productVMs
                    select new SelectListItem()
                    {
                        Text=p.ProductName.ToUpper(),
                        Value=p.ProductID.ToString()
                    }
                    ).ToList();
        }

        [HttpPost]
        public ActionResult SatisYap(SatisVM satis)
        {
            //order tabla ekle
            return View();
        }

    }
}