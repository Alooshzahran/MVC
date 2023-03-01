using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace prepare_1_2_MVC.Models
{
    public class Users
    {

        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(5)]
        public string Name { get; set; }
        [Required]
        [Range(1,51)]
        public int Age { get; set; }
    }
}