using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Infant.Application.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Additional properties as needed
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }


    }
}
