using System.ComponentModel.DataAnnotations;

namespace IrrigationInformationSystem.Application.Models.Account
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
        public string Username { get; set; }
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
        public string ConfirmPassword { get; set; }
    }
}
