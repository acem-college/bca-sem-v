using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildNutrition.Application.Models.Users
{
    public class CreateUserVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public required string UserName { get; set; }
        public string Username { get; internal set; }
        public required string Email { get; set; }
        public required string Password { get; set; }


    }
}
