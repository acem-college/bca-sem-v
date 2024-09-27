using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirQualityIndex.Application.Models.Accounts
{
    public class SignUpVM
    {
        [Required]
        [MaxLength(300)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(300)]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [MaxLength(300)]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(300)]
        public string Email { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(30)]
        public string Password { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(30)]
        public string ConfirmPassword {  get; set; }
    }
}
