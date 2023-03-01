using prepare_5_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prepare_5_2.Controllers
{
    public class button1Controller : Controller
    {
        // GET: button1
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult button(Employee employee)
        {
            if(ModelState.IsValid)
            {
                return View(employee);
            }
            return View("Index");
        }
    }
}