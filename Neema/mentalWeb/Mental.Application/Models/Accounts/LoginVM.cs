using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mental.Application.Models.Accounts
{
    public class LoginVM
    {
        [Required]
        [MaxLength(300)]
        public string UserName { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(50)]
        public string Password { get; set; }
    }
}
