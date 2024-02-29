using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim.Application.Models.Accounts
{
    public class SignUpVm
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
        [MaxLength(100)]
        public string Username { get; set; }
       
        public DateTime DateOfBirth { get; set; }
    }
}
