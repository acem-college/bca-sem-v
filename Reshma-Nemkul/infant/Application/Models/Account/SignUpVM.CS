using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infant.Application.Models.Account
{
    public class SignUpVM
    {
        [Required ]
        [MaxLength(300)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(300)]
        public string LastName { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(300)]
        public string Email { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(300)]
        public string Password { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(300)]
        public string ConfirmPassword { get; set; }
        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }

    }
}
