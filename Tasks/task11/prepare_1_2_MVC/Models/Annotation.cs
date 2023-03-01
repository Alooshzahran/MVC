using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace prepare_1_2_MVC.Models
{
    public class Annotation
    {
        [Required]

        [Range(1, 150, ErrorMessage = "The age must be between 1 and 150.")]
        public int Age { get; set; }
        [StringLength(100, ErrorMessage = "The name cannot be longer than 100 characters.")]

        public string Name { get; set; }
    }
}