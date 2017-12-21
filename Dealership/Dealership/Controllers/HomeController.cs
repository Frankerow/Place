using Dealership.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using entities;

namespace Dealership.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Viewing()
        {
            return View();
        }
        public ActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(ProductVM product)
        {
            product.Id = Guid.NewGuid();
            ProductVM.AddProduct(product);
            //Repo.repo.AddProduct(
            //     new Product()
            //     {
            //         Id = product.Id,
            //         Country = product.Country,
            //         Mark = product.Mark,
            //         Model = product.Model,
            //         Presense = product.Presense,
            //         Price = product.Price


            //     });
            Session.Add("GuidProd", product.Id);
            return RedirectToAction("AddTechnicalData");
        }

        public ActionResult AddTechnicalData()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTechnicalData(TechnicalDataVM technicalDataVM)
        {
            string id = Session["GuidProd"].ToString();
            technicalDataVM.Id = Guid.Parse(id);
            TechnicalDataVM.AddTechnicalData(technicalDataVM);
            return View("Index");
        }

        public ActionResult ListProduct()
        {
           
            return View(ProductVM.GetAllProduct());
        }

        public ActionResult Details()
        {
            return View(TechnicalDataVM.GetTechnicalDataById());
        }
    }
}