using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task_31_1_MVC.Controllers
{
    public class EmptyController : Controller
    {
        // GET: Empty
        public ActionResult Index()
        {
            return View();
        }

        public string Name()
        {
            return "My name is batool";
        }
        public string color()
        {
            return "blue";
        }
        public int Age()
        {
            return 23;
        }
        public string code()
        {
            return "coding Academy";
        }

    }
}