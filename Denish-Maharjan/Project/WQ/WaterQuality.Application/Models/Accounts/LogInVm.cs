using System.ComponentModel.DataAnnotations;

namespace WaterQualityMVC.ui.Controllers.Accounts
{
    public class LogInVm
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [EmailAddress] // Corrected: Moved from Password to Email.
        [MaxLength(300)]
        public string Email { get; set; }

        [Required]
        [MinLength(8)] // Assuming you want a MinLength for the password as well.
        [MaxLength(30)]
        public string Password { get; set; }

        [Required]
        [MinLength(8)]
        [MaxLength(30)]
        public string ConfirmPassword { get; set; }
    }
}
