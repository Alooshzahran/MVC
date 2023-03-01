using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1_2_Morining_MVC.Controllers
{
    public class Default1Controller : Controller
    {

        private List<Models.Class1> employee = new List<Models.Class1> 
        {
        new Models.Class1{ Id = 1,Name= " batool" , Description="batool"},
        new Models.Class1{Id=2 , Name="rama", Description="rama"}
        };
        // GET: Default1
        public ActionResult Index()
        {
            return View(employee);
        }
    }
}