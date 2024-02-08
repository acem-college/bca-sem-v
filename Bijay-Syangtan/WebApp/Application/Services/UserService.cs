using WebApp.Application.Interfaces;
using WebApp.Application.Models.User;

namespace WebApp.Application.Services
{
    public class UserService : IUserService
    {
        private ListUserVM userVm;

        public async Task<List<ListUserVM>> ListAsync(CancellationToken cancellationToken)
        {
            var Users = new List<ListUserVM>();
            Users.Add(new ListUserVM
            {
                Id = Guid.NewGuid(),
                FirstName = "Hemu",
                LastName = "JI",
                Email = "hem@12.np",
                PhoneNumber = "9866265406"
            });

            return Users;
        }

        public async Task<ListUserVM> CreateAsync(SaveUser user, CancellationToken cancellationToken)
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

