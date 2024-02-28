using mvcproject1.Domain.Entities;

namespace mvcproject1.Infrastructure.Persistence
{
    public class Users
    {
        static Users()
        {
            Profiles = new List<UserProfile>();
            Profiles.Add(new UserProfile
            {
                Id = Guid.NewGuid(),
                FirstName = "Hem",
                LastName = "Dahal",
                Email = "hem@aecm.com.np",
                PhoneNumber = "9814317777"
            });
        }

        public static List<UserProfile> Profiles { get; set; }
    }
}
