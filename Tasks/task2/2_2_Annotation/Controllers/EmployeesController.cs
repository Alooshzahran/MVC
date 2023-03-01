using _2_2_Annotation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2_2_Annotation.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tutorial()
        {
            return View();
        }
        public ActionResult SaveUser(Employee emp)
        {
            if(ModelState.IsValid)
            {
                return View(emp);
            }
            else
            {
                return View("Tutorial");
            }


        }



        public ActionResult R1()
        {
            return View();


        }
        public ActionResult R2(Employee emp)
        {
            if (ModelState.IsValid)
            {
                return View(emp);
            }
            else
            {
                return View("R1");
            }


        }
    }
}