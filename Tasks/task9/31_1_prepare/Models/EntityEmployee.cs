using _31_1_prepare.Content;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _31_1_prepare.Models
{
    public class EntityEmployee :DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}