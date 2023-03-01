using _31_1_prepare.Content;
using _31_1_prepare.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _31_1_prepare.Controllers
{
    public class EntityController : Controller
    {
        // GET: Entity
        public ActionResult Batool()
        {
            EntityEmployee entityEmployee=new EntityEmployee();
            Employee employee= entityEmployee.Employees.Single(s=>s.id== 1);   


            return View(employee);
        }
        public string batoolname()
        {
            return "batool";
        }
    }
}