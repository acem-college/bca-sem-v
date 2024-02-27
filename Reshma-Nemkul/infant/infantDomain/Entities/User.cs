
using Microsoft.AspNetCore.Identity;

namespace Infant.Domain.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateofBirth { get; set; }
        public string UserName { get; set; }
    }
}
