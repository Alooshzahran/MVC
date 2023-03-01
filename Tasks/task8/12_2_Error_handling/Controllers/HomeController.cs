using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _12_2_Error_handling.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HandleError(ExceptionType = typeof(DivideByZeroException ), View ="Error")]

        public ActionResult error()
        {
            int x = 10;
            int y = 0;
            int z = x / y;

            try
            {

            }catch(Exception e)
            {
                if(e is DivideByZeroException)
                {
                    return View("_math");
                }
            }
            return Content(z.ToString());

        }

        public ActionResult errorPage()
        {

           

            return View("error");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}