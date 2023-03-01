using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _5_2_Mvc.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int Price { get; set; }
    }
}