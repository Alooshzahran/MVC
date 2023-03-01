using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task_1_2_mvc.Models;

namespace Task_1_2_mvc.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {

            List<Employee> emp = new List<Employee>();
            emp.Add(new Employee { ID = 1, Name = "Batool", Major = "Network", Faculty = "JUST" });
            emp.Add(new Employee { ID = 2, Name = "Rama", Major = "Finace", Faculty = "Yurmouk" });
            emp.Add(new Employee { ID = 3, Name = "Luijuin", Major = "IT", Faculty = "IT" });
            emp.Add(new Employee { ID = 4, Name = "Rahma", Major = "IT", Faculty = "IT" });
            emp.Add(new Employee { ID = 5, Name = "Haya", Major = "Literature", Faculty = "IT" });
            emp.Add(new Employee { ID = 6, Name = "Ayah", Major = "Econmic", Faculty = "Yurmouk" });

            return View(emp);
        }
    }
}