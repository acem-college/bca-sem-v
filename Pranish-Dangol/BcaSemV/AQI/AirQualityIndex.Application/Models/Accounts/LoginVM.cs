using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirQualityIndex.Application.Models.Accounts
{
    public class LoginVM
    {
        [Required]
        [MaxLength(300)]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
