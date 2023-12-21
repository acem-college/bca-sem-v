using System.ComponentModel.DataAnnotations;

namespace webapp.Application.Model.User
{
    public class SaveUserVM
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(10)]
        public string PhoneNumber { get; set; }
    }
}
