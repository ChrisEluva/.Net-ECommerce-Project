﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ModelPOCO
{
    public class Customers
    {
        [Key]
        public int CustomerID { get; set; }
        
        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is a required field")]
        public string Email { get; set; }
        
        [Required(ErrorMessage="Password is a required field")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
       // public int Phone { get; set; }
    }
}
