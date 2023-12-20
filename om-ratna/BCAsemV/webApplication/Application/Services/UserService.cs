using webApplication.Application.Inerfaces;
using webApplication.Application.Model.User;

namespace webApplication.Application.Services
{
    public class UserService : IUserServices
    {
        public async Task<List<ListUserVM>> ListAsync(CancellationToken cancellationToken)
        {
            var users = new List<ListUserVM>();
            users.Add(new ListUserVM
            {
                Id = Guid.NewGuid(),
                FirstName = "om",
                LastName = "Bajracharya",
                Email = "ombajrachrya4@gmail.com",
                PhoneNumber = "99999999999"
            });
            return users;
        }
    }
}
