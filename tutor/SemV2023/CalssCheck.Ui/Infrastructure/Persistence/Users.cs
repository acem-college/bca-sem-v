using ClassCheck.Ui.Domain.Entities;

namespace ClassCheck.Ui.Infrastructure.Persistence
{
    public static class Users
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
                PhoneNumber = "9988876766"
            });
        }

        public static List<UserProfile> Profiles { get; set; }
    }
}
