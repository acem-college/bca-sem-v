﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildNutrition.Application.Models.Users
{
    public class UserVM
    {
        public int UserId { get; set; }
        /*  public string UserName { get; set; }*/
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
