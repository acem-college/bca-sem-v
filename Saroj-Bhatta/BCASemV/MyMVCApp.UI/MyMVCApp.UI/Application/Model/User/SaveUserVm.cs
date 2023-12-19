using System.ComponentModel.DataAnnotations;

namespace MyMVCApp.UI.Application.Model.User
{
    public class SaveUserVm
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
        [MaxLength(300)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(20)]
        
        public string Phone { get; set; }
    }
}
