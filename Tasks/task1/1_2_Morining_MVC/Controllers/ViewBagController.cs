using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1_2_Morining_MVC.Controllers
{
    public class ViewBagController : Controller
    {
        // GET: ViewBag
        public ActionResult Index()
        {
            ViewBag.country= new List<string> {"India" , "Jordan" }; 
            return View();
        }
    }
}