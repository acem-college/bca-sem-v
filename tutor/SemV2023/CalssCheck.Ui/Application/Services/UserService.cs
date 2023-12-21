using ClassCheck.Ui.Application.Interfaces;
using ClassCheck.Ui.Application.Models.User;

namespace ClassCheck.Ui.Application.Services
{
    public class UserService : IUserServie
    {
        public async Task<List<ListUserVM>> ListAsync(CancellationToken cancellationToken)
        {
            var users = new List<ListUserVM>();
            users.Add(new ListUserVM
            {
                Id = Guid.NewGuid(),
                FirstName = "Hem",
                LastName = "Dahal",
                Email = "hem@aecm.com.np",
                PhoneNumber = "9988876766"
            });

            return users;
        }
    }
}
