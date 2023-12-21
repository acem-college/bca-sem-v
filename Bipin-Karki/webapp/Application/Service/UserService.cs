using webapp.Application.Interface;
using webapp.Application.Model.User;

namespace webapp.Application.Service
{
    public class UserService : IUserService
    {

        public async Task<List<ListUserVM>> ListAsync(CancellationToken cancellationToken)
        {
            var Users = new List<ListUserVM>();
            Users.Add(new ListUserVM
            {
                Id = Guid.NewGuid(),
                FirstName = "Hem",
                LastName = "Dalal",
                Email = "hem@12.np",
                PhoneNumber = "98662654"
            });
        return Users;
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
