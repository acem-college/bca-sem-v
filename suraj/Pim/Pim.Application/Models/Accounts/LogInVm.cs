using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim.Application.Models.Accounts
{
    public class LogInVm
    {
        [Required]
        [MaxLength(300)]
        public string Username { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(300)]
        public string Password { get; set; }
      
      
        
     
    }
}
