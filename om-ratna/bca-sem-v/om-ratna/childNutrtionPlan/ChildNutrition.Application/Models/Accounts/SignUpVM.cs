﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildNutrition.Application.Models.Accounts
{
    public class SignUpVM
    {
        [Required]
        [MaxLength(300)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(300)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(300)]
        public string Email { get; set; }
        EmailAddressAttribute EmailAddressAttribute { get; set; }
        [Required]
        [MaxLength(300)]
        public string Password { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(15)]
        public string ConfirmPassword { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        public string Username { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        
    }
}
