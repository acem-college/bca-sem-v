using System.ComponentModel.DataAnnotations;

namespace webApplication.Application.Model.User
{
    public class SaveUserVM
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(300)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(500)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
    }
}
