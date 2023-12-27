using webApplication.Application.Model.User;
using webApplication.Domain.Entities;

namespace webApplication.ui.Infrastructure.Persistence
{
    public class Users
    {
        static Users()
        {
            Profiles = new List<UserProfile>();
            Profiles.Add(new UserProfile
            {
                Id = Guid.NewGuid(),
                FirstName = "om",
                LastName = "Bajracharya",
                Email = "ombajrachrya4@gmail.com",
                PhoneNumber = "99999999999"
            });
    }
       public static List<UserProfile> Profiles { get; set; }
    }
}
