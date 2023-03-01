using _5_2_Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5_2_Mvc.Controllers
{
    public class Search1Controller : Controller
    {
        // GET: Search1
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Index1()
        {
            return View();
        }


        private readonly List<Products> products = new List<Products>
    {
        new Products { Id = 1, Name = "Product 1", Description = "Description 1", Price = 100 },
        new Products { Id = 2, Name = "Product 2", Description = "Description 2", Price = 200 },
        new Products { Id = 3, Name = "Product 3", Description = "Description 3", Price = 300 },
        new Products { Id = 4, Name = "Product 4", Description = "Description 4", Price = 400 },
        new Products { Id = 5, Name = "Product 5", Description = "Description 5", Price = 500 }
    };
        [HttpPost]
        public ActionResult Search(string name, int? price)
        {
            var result = products.Where(p =>
                ( p.Name.Contains(name)) &&
                ( p.Price == price));

            return View("Index1", result);
        }
    }
}