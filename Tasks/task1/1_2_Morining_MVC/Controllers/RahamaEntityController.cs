using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1_2_Morining_MVC.Controllers
{
    public class RahamaEntityController : Controller
    {
        // GET: RahamaEntity
        Entities db= new Entities();
        public ActionResult Index()
        {

            return View();
        }
    }
}