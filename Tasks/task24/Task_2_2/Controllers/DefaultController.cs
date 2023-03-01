using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task_2_2.Models;

namespace Task_2_2.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Read(User user)
        {
            if(ModelState.IsValid)
            {
                return View(user);
            }
            else
            {
                return View("Create");
            }
            
        }

        public ActionResult Update()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }
    }
}