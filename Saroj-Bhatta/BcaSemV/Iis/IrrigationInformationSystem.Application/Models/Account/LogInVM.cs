using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrrigationInformationSystem.Application.Models.Account
{
    public class LogInVM
    {
        [Required]
        [MaxLength(300)]
        public string Username { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(100)]
        public string Password { get; set; }
    }
}
