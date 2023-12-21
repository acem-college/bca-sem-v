using System.ComponentModel.DataAnnotations;

namespace Classwork.MVC.Application.Model.User
{
    public class SaveUserVM
    {
        [Required]
        public Guid id { get; set; }
        [Required]
        [MaxLength
            (100)]
        public string name { get; set; }
        [Required]
        [MaxLength (100)]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        [MaxLength (20)]
        public string phone { get; set; }
        [Required]
        public string address { get; set; }
    }
}
