using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _31_1_prepare.Content
{
    [Table("Employee")]
    public class Employee
    {
        public int id { set; get; }

        public string name { set; get; }

        public int Age { set; get; }
    }
}