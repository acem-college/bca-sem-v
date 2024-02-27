using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infant.Application.Models.Account
{
    public class LoginVM
    {
        [Required]
        [MaxLength(300)]
        public string UserName { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(300)]
        public string Password { get; set; }


    }
}
