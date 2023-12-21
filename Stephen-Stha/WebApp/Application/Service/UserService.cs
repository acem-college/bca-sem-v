using LifeOnLand.Application.Interfaces;
using LifeOnLand.Application.Models.User;
using Microsoft.AspNetCore.Components.QuickGrid;

namespace LifeOnLand.Service
{
    public class UserService : IUserService
    {
        public async Task<List<ListUserVM>> ListAsync(CancellationToken cancellationToken)
        {
            var users = new List<ListUserVM>();
            users.Add(new ListUserVM()
            {
                Id = Guid.NewGuid(),
                FirstName = "Babu",
                LastName = "Rao",
                Email =  "babu@gmail.com",
                PhoneNumber = "1234567890"
            }    
            );
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

