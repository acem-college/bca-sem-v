using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mental.Application.Models.Accounts
{
    public class SignUpVM
    {
        [Required] //data annotation
        [MaxLength(300)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength (300)]
        public string LastName { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        [MaxLength(300)]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(300)]
        public string Email { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(100)]
        public string Password { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(100)]
        public string Confirm_Password {get; set;}

    }
}
