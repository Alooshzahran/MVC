using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prepare_5_2.Controllers
{
    public class ButtonController : Controller
    {
        // GET: Button
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calulator(int id)
        {
            ViewBag.id = id;
           
            return View();
        }
    }
}