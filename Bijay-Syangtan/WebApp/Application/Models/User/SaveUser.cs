using System.ComponentModel.DataAnnotations;

namespace WebApp.Application.Models.User
{
    public class SaveUser
    {
       
        public Guid Id { get; internal set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; internal set; }

        [Required]
        [MaxLength(50)]
        [EmailAddress]

        public string address { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; internal set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; internal set; }

        public string PhoneNumber { get; internal set; }
    }
}
