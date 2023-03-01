using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _2_2_Annotation.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Please enter your ID")]

        public int Id { get; set; }

        [Required]
        [StringLength(5)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Range(18, 40)]
        public int Age { get; set; }
    }
}