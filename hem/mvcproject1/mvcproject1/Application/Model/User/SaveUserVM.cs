using System.ComponentModel.DataAnnotations;

namespace mvcproject1.Application.Model.User
{
    public class SaveUserVM
    {

        [Required]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(300)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(30)]
        public string PhoneNumber { get; set; }
    }
}
