using Microsoft.AspNetCore.Identity;

namespace Pim.Domain.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB {  get; set; }
    }
}
