using _1_2_Morining_MVC.Models;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1_2_Morining_MVC.Controllers
{
    public class DefaultController : Controller
    {


        private List<Models.Class1> user1 = new List<Models.Class1>()
        {
            new Models.Class1{Id=1 , Description="batool" , Name="batool"},
            new Models.Class1{Id=2 ,Name="rama", Description="rama"}
        };

        public ActionResult user()
        {
            return View(user1);
        }
    } }


