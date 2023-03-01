using prepare_1_2_MVC.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prepare_1_2_MVC.Controllers
{
    public class AnnotationController : Controller
    {
        // GET: Annotation
        public ActionResult Sample()
        {
           
            return View();
        }

        public ActionResult Tutorial()
        {

            return View();
        }

        public ActionResult SaveUser(Users obj)
        {
if(ModelState.IsValid)
            {
                return View(obj);
            }
            else
            {
                return View("Tutorial");
            }
            
        }
    }
}