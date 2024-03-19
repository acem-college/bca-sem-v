using System.ComponentModel.DataAnnotations;

namespace ChildNutrition.Application.Models.Accounts
{
    public class LogInVM
    {
        [Required]
        [MaxLength(300)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(15)]
        public string Password { get; set; }

    }
}

