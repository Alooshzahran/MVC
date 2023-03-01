using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _31_1_prepare.Controllers
{
    public class ViewBagController : Controller
    {
        // GET: ViewBag
        public ActionResult Index()
        {

            return View();
        }
    }
}