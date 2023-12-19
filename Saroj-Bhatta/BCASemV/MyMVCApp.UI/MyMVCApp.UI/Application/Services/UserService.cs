using MyMVCApp.UI.Application.Interfaces;
using MyMVCApp.UI.Application.Model;

namespace MyMVCApp.UI.Application.Services
{
    public class UserService : IUserService

    {
        public async Task<List<ListUserVm>> ListsAsync(CancellationToken cancellationToken)
        {
            var users = new List<ListUserVm>();
            users.Add(new ListUserVm
            {
                Id = Guid.NewGuid(),
                FirstName = "Saroj",
                LastName = "Bhatta",
                Email = "Vattasaroj10@gmail.com",
                Phone = "9864685890"
            });
            return users;
        }
    }
}
