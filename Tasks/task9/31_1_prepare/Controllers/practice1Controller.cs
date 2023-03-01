using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _31_1_prepare.Controllers
{
    public class practice1Controller : Controller
    {
        // GET: practice1
        public ActionResult Index()
        {

            ViewBag.country = new List<string>() { "Undia", "USA", "Jordan" };
            return View();
        }

        public ActionResult viewData()
        {

            ViewData["country"] = new List<string>() { "Undia", "USA", "Jordan" };
            return View();
        }
    }
}