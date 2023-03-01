using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _31_1_prepare.Content
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult employee()
        {
            Employee employee = new Employee();
            employee.id = 1;
            employee.name = "batool";
            employee.Age = 23;
           // ViewBag.employee = employee;
            return View(employee);
        }
    }
}