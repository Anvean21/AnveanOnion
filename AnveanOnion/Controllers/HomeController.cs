using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AnveanOnion.Domain.Core;
using AnveanOnion.Domain.Interfaces;
using AnveanOnion.Services.Interfaces;

namespace AnveanOnion.Controllers
{
    public class HomeController : Controller
    {
        IProductRepository repo;
        IOrder order;
        public HomeController(IProductRepository r, IOrder o)
        {
            repo = r;
            order = o;
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            repo.Create(product);
            repo.Save();
            return RedirectToAction("Index");
        }
        public ActionResult Index()
        {
            var products = repo.GetProductsList();
            return View(products);
        }
        public ActionResult Buy(int id)
        {
            Product product = repo.GetProduct(id);
            order.MakeOrder(product);
            return View();
        }
        protected override void Dispose(bool disposing)
        {
            repo.Dispose();
            base.Dispose(disposing);
        }
    }
}