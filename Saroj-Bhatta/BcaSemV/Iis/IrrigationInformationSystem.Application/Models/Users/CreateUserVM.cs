﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrrigationInformationSystem.Application.Models.Users
{
    public class CreateUserVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public  DateTime DateOfBirth {  get; set; } 
        public string Username { get; set; }
        public string Email { get; set; }
    }
}
