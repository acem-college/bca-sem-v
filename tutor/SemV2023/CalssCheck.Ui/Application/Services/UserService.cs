using ClassCheck.Ui.Application.Interfaces;
using ClassCheck.Ui.Application.Models.User;
using Microsoft.AspNetCore.Components.QuickGrid;

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

        public async Task<ListUserVM> CreateAsync(SaveUserVM user, CancellationToken cancellationToken)
        {
            var userVM = new ListUserVM
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber
            };
            return userVM;
        }
    }
}
