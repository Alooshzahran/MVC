using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Task_2_2.Models
{
    public class User
    {
        
        public int Id { set; get; }

        [Required]
        [StringLength(12)]
        public string First_Name { get; set; }

        [Required]
        [StringLength(12)]
        public String Last_Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
       // [RegularExpression(@"^(07)[7-9]{1}[0-9]{7}$")]
        public int Phone { get; set; }

        [Required]
        [Range(18,50)]
        public int Age { get; set; }

        [Required]
        [MaxLength(10)]
        public string Job_Title  { get; set; }



        public Nullable<bool> Gender { get; set; }

    }
}